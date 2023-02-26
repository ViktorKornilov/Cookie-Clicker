using System;
using TMPro;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public int clicks;
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
    }

    private void OnMouseDown()
    {
        clicks++;
        transform.localScale = Vector3.one * 1.2f;

        clicksText.text = clicks.ToString();
        audio.Play();
        //audio.PlayOneShot(audio.clip);
    }
}
