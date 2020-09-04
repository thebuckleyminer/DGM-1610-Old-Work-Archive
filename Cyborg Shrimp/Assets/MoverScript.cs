using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 5f;
    public int score = 100;

    private void Update()
    {
        var vInput = speed *Time.deltaTime* Input.GetAxis("Vertical");
        var hInput= speed *Time.deltaTime* Input.GetAxis("Horizontal");
        
        transform.Translate(hInput,vInput,0);
    }
}

