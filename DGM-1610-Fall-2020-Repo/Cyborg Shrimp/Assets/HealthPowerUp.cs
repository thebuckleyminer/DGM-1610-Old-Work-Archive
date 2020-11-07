using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This Script is used to increase the health variable by one when triggered 

public class HealthPowerUp : MonoBehaviour
{
    public float health; //This is the Health Variable

    private void OnTriggerEnter(Collider other)
    {
        health++; // This increases the health by one each time the trigger function is called
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
