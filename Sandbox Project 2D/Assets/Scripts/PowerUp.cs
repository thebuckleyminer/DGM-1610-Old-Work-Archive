using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int score;
    private void OnTriggerEnter(Collider other)
    {
        score++;
        //++ is the c# equivalent of +=
        print(score);
    }
}
