﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horosontalInput;
    public float speed = 10.0f;
    public float xAxisRange = 15.0f;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xAxisRange)
        {
            transform.position = new Vector3(-xAxisRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xAxisRange)
        {
            transform.position = new Vector3(xAxisRange, transform.position.y, transform.position.z);
        }
        horosontalInput = Input.GetAxis("Horizontal");
        transform.Translate(speed * Time.deltaTime * horosontalInput * Vector3.right);
        
    }
}
