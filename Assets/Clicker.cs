using System;
using TMPro;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public int clicks;
    public int clickPower;
    public float shrinkSpeed;
    public TMP_Text clicksText;
    public AudioSource audio;

    private void Start()
    {
        clicksText.text = clicks.ToString();
    }

    private void Update()
    {
        if (transform.localScale.x > 1)
        {
            transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        }
        
        clicksText.text = clicks.ToString();
    }

    private void OnMouseDown()
    {
        clicks += clickPower;
        transform.localScale = Vector3.one * 1.2f;
        
        audio.Play();
        //audio.PlayOneShot(audio.clip);
    }
}
