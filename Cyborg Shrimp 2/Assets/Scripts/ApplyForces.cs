﻿using UnityEngine;

public class ApplyForces : MonoBehaviour
{
    public Rigidbody rBody;
    public float force = 30;
    

    void OnMouseDown()
    {
        rBody.AddForce(0,force,0);
    }


    void Update()
    {
        //rBody.AddForce(0,force,0); 
    }
}
