﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float lastLaunch;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time-1-lastLaunch>0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                Debug.Log(lastLaunch);
                lastLaunch = Time.time;
                Debug.Log(lastLaunch);
                
            }
        }
    }
}
