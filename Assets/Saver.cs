using System;
using UnityEngine;

public class Saver : MonoBehaviour
{
    public Clicker clicker;
    public BuyButton button1;
    public BuyButton button2;
    public GameManager gameManager;

    private void Awake() => Load();

    private void OnApplicationPause(bool isPaused)
    {
        if (isPaused) Save();
    }

    private void OnApplicationQuit()
    {
        Save();  
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Removing save");
            PlayerPrefs.DeleteAll();
            enabled = false;
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("clicks",clicker.clicks);
        PlayerPrefs.SetInt("clickPower",clicker.clickPower);
        
        PlayerPrefs.SetInt("button1_price",button1.price);
        PlayerPrefs.SetInt("button1_amount",button1.amount);
        
        PlayerPrefs.SetInt("button2_price",button2.price);
        PlayerPrefs.SetInt("button2_amount",button2.amount);
        
        PlayerPrefs.SetInt("cps",gameManager.cps);
    }

    public void Load()
    {
        clicker.clicks = PlayerPrefs.GetInt("clicks");
        clicker.clickPower = PlayerPrefs.GetInt("clickPower",1);

        button1.price = PlayerPrefs.GetInt("button1_price",button1.price);
        button1.amount = PlayerPrefs.GetInt("button1_amount");
        
        button2.price = PlayerPrefs.GetInt("button2_price",button2.price);
        button2.amount = PlayerPrefs.GetInt("button2_amount");
        
        gameManager.cps = PlayerPrefs.GetInt("cps");
    }
}
