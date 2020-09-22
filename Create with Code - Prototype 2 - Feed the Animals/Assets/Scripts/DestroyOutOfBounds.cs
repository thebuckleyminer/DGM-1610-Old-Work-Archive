using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float zMaxValue = 30.0f;

    private float zMinValue = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zMaxValue)
        {
            Destroy(gameObject);
        } else if (transform.position.z < zMinValue)
        {
            Destroy(gameObject);
        }
    }
}
