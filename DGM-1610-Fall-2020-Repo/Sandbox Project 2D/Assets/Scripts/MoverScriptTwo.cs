using UnityEngine;

public class MoverScriptTwo : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 rotationVector3;
    public int count;
    private void Update()
    {
        if (transform.rotation.y > 90)
        {
            print("Greater");
        }
        rotationVector3.y = speed * Time.deltaTime;
        transform.Rotate(rotationVector3);
    }
}
