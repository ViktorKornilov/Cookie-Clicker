using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public  int price;
    public int amount;
    
    public TMP_Text priceText;
    public TMP_Text amountText;
    public Button button;
    public Clicker clicker;
    public AudioSource audio;

    private void Start()
    {
        button.onClick.AddListener(OnClick);
        
        priceText.text = "Price:" + price;
        amountText.text = amount.ToString();
    }

    public void OnClick()
    {
        clicker.clicks -= price;
        price *= 2;
        amount++;

        priceText.text = "Price:" + price;
        amountText.text = amount.ToString();
        audio.Play();
        
    }

    private void Update()
    {
        button.interactable = clicker.clicks >= price;
    }
}
