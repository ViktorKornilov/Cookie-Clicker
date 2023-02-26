using System;
using UnityEngine;

public class Saver : MonoBehaviour
{
    public Clicker clicker;
    
    private void Awake() => Load();

    private void OnApplicationPause(bool isPaused)
    {
        if (isPaused) Save();
    }

    private void OnApplicationQuit() => Save();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("clicks",clicker.clicks);
        PlayerPrefs.SetInt("clickPower",clicker.clickPower);
    }

    public void Load()
    {
        clicker.clicks = PlayerPrefs.GetInt("clicks");
        clicker.clickPower = PlayerPrefs.GetInt("clickPower",1);
    }
}
