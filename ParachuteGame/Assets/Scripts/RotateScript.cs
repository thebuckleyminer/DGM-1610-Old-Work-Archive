using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float horosontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horosontalInput = Input.GetAxis("Horizontal");
        
        transform.Rotate(0, 0, 45 * horosontalInput);
        Debug.Log(horosontalInput);
        

    }
}
