using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float horizontalInput;
    //This will be the limit of the swing of the parachuter can pivot
    public float rotationBound = 45.0f;
    public float wilkinsonEulerAngleTracker = 0.0f;
    public float angleMoved = 1.0f;
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0 && horizontalInput > 0)
        {
            if (wilkinsonEulerAngleTracker < 45.0f)
            {
                wilkinsonEulerAngleTracker += angleMoved;
                transform.Rotate(0,0,angleMoved);
            }
        }
        
        if (horizontalInput != 0 && horizontalInput < 0)
        {
            if (wilkinsonEulerAngleTracker > -45.0f)
            {
                wilkinsonEulerAngleTracker -= angleMoved;
                transform.Rotate(0,0,-angleMoved);
            }
        }
        
        if (horizontalInput == 0)
        {
            if (wilkinsonEulerAngleTracker > 0)
            {
                wilkinsonEulerAngleTracker -= angleMoved;
                transform.Rotate(0,0,-angleMoved);
            }
            if (wilkinsonEulerAngleTracker < 0)
            {
                wilkinsonEulerAngleTracker += angleMoved;
                transform.Rotate(0,0,+angleMoved);
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

