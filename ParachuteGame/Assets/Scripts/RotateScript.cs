using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float horizontalInput;
    //This will be the limit of the swing of the parachuter can pivot
    public float rotationBound = 30.0f;
    public float wilkinsonEulerAngleTracker = 0.0f;
    public float angleMoved = 0.50f;
    public float horizontalSpeed = 10.0f;
    public float horizontalInputAngle;
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        

        transform.Translate(horizontalInput * horizontalSpeed * Time.deltaTime, 0, 0, Space.World);

        
        if (horizontalInput != 0)
        {
            horizontalInputAngle = 45 * horizontalInput;
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
        
        
        if (horizontalInput == 0)
        {
            horizontalInputAngle = 0.0f;
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

        
        


































        //if (horizontalInput != 0 || transform.rotation.z != 0)
        //{
        //    transform.Rotate(0, 0, 10 * Time.deltaTime);
        //}



        //horizontalInput = Input.GetAxis("Horizontal");
        //Debug.Log(transform.rotation.z);
        //transform.rotation.z = horizontalInput;
        //transform.Rotate(0, 0, rotationBound * horizontalInput);
        //Debug.Log(horizontalInput);

        //if transform.
    }
}

