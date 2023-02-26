using UnityEngine;

public class Saver : MonoBehaviour
{
    public Clicker clicker;
    
    private void Awake()
    {
        clicker.clicks = PlayerPrefs.GetInt("clicks");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("clicks",clicker.clicks);
    }
}
