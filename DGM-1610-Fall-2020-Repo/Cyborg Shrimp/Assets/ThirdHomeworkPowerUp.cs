using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the third homework power up. I chose to make the player speed ten times faster for this function.
public class ThirdHomeworkPowerUp : MonoBehaviour
{
    public int speedUp;

    private void OnTriggerEnter(Collider other)
    {
        //This increases the player speed by ten times when hit.
        speedUp *= 10;
        
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
