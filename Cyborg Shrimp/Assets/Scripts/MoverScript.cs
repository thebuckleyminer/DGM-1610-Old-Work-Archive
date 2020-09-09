// Christopher Wilkinson following Anthony Romrell in class. Sep/2020
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 5f;
    public int score = 100;

    private void Update()//update will run as fast as it can and hit all the frames it can
    { //*Time.deltaTime for the same framerate
        var vInput = Time.deltaTime*speed * Input.GetAxis("Vertical"); //What this does is use the up and down arrows
        var hInput = Time.deltaTime*speed * Input.GetAxis("Horizontal");//Gets the Horizontal movement -left and right arrow keys + A and D + joystick
        transform.Translate(hInput,vInput,0.1f);
    }

    public void MoveUp()
    {
        transform.Translate(0,speed,0);
        print("Up.");
    }
    public void MoveDown()
    {
        transform.Translate(0,-speed,0);
        print("Down.");
    }

    public void MoveRight()
    {
        transform.Translate(speed,0,0);
    }

    public void MoveLeft()
    {
        transform.Translate(-speed, 0, 0);
    }
}

