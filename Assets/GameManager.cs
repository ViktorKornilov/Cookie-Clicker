using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Clicker clicker;
    public int cps;
    public TMP_Text cpsText;
    
    private void Start()
    {
        InvokeRepeating("MakeClicks",0,1);
    }

    private void Update()
    {
        cpsText.text = "CPS:" + cps;
    }

    void MakeClicks()
    {
        clicker.clicks += cps;
    }

    public void BuyFlipper()
    {
        print("flipper");
        cps += 1;
    }

    public void BuyDoubleClicks()
    {
        clicker.clickPower *= 2;
    }
}
