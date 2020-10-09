using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float horizontalInput;
    // Max Deg of pivot left and right (absolute value) (total pivot range = 2x)
    public float rotationBound = 30.0f;
    // Since I was having a hard time with understanding what a Quaternion was, I desited to try my hand at my own approach
    // This vairable stores the angle (degrees) as a float value for me to use
    public float wilkinsonEulerAngleTracker = 0.0f;
    // This variable limits the speed that the rotation happens (unit deg)
    public float angleMoved = 0.50f;
    // This is the speed the player moves linearly left and right through the scene
    public float horizontalSpeed = 10.0f;
    
    void Update()
    {
        //Get the input from the player's device
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Left and right movement
        transform.Translate(horizontalInput * horizontalSpeed * Time.deltaTime, 0, 0, Space.World);

        // Pivot left and right logic
        if (horizontalInput != 0)
        {
            if (horizontalInput > 0)
            {
                if (wilkinsonEulerAngleTracker < rotationBound)
                {
                    wilkinsonEulerAngleTracker += angleMoved;
                    transform.Rotate(0,0,angleMoved);
                }
            }
            if (horizontalInput < 0)
            {
                if (wilkinsonEulerAngleTracker > -rotationBound)
                {
                    wilkinsonEulerAngleTracker -= angleMoved;
                    transform.Rotate(0,0,-angleMoved);
                }
            }
        }
        // Return to center logic
        if (horizontalInput == 0)
        {
            if (wilkinsonEulerAngleTracker > 0)
            {
                wilkinsonEulerAngleTracker -= angleMoved/2;
                transform.Rotate(0,0,-angleMoved/2);
            }
            if (wilkinsonEulerAngleTracker < 0)
            {
                wilkinsonEulerAngleTracker += angleMoved/2;
                transform.Rotate(0,0,+angleMoved/2);
            }
        }
    }
}

