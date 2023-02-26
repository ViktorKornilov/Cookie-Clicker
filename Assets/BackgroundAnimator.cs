using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnimator : MonoBehaviour
{
    public Camera cam;
    public float speed;
    
    private void Update()
    {
        cam.backgroundColor = Color.HSVToRGB(Time.time * speed % 1, 0.7f, 0.5f);
    }
}