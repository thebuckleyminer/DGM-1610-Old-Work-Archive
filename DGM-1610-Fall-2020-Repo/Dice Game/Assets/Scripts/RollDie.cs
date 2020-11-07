using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollDie : MonoBehaviour
{
    public int dieNumber;
    public bool hasBeenRolled = false;
    public bool avaiableToRool = true;
    
    // Start is called before the first frame update
    void Start()
    {
        dieNumber = Random.Range(1, 7);
        Debug.Log(dieNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RollDiceFunction()
    {
        if (avaiableToRool)
        {
            dieNumber = dieNumber = Random.Range(1, 7);
        }
    }
}


