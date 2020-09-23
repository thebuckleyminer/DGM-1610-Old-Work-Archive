using System;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    //Public if you want it to be VISIBLE inside the unity editor
    //Private if you want it HIDDEN
    public float speed = 10.0f;
    public int score = 100;
    //<Public or Private(Access Modifier)> <Data Type(ex. float int bool string)> <=> <what the variable is> <;>
    //Variables first letter lower case, then camelcase after that.
    
    //Functions always start with an upper case letter
    //Functions that do not return anything use the word void. Use "function" if returns something.
    //Function name followed by ()
    //And Function content is withing { }
    private void Update()
    {
        var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(vInput, hInput*Time.deltaTime, 0);
    }

    public void Up()
    {
        transform.Translate(0, speed, 0);
    }

    public void Down()
    {
        transform.Translate(0, -speed, 0);
    }

    public void Left()
    {
        transform.Translate(-speed, 0, 0);
    }

    public void Right()
    {
        transform.Translate(speed, 0, 0);
    }
}
