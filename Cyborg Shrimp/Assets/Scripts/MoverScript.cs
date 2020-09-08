using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float x, y, z;
    public float speed = 3f;
    
    //public float speed = 5f;
    //public int score = 100;

    private void Start()
    {
        Debug.Log(message:"Hello World!");
    }

    private void Update()
    {
        x = speed*Input.GetAxis("Horizontal")*Time.deltaTime;
        y = speed*Input.GetAxis("Vertical")*Time.deltaTime;
        transform.Translate(x,y,z);
        //var vInput = speed *Time.deltaTime* Input.GetAxis("Vertical");
        //var hInput= speed *Time.deltaTime* Input.GetAxis("Horizontal");
        //transform.Translate(hInput,vInput,0);
    }
}

