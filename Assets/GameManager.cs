using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Clicker clicker;
    
    public void BuyFlipper()
    {
        print("flipper");
    }

    public void BuyDoubleClicks()
    {
        clicker.clickPower *= 2;
    }
}
