using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script adds fifty ammo each time it is triggered.
public class AmmoPowerUp : MonoBehaviour
{
    public int ammo;

    private void OnTriggerEnter(Collider other)
    {
        ammo += 50;
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
