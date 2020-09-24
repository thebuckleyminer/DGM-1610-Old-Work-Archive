using UnityEngine;
using UnityEngine.Events;

public class PowerUp : MonoBehaviour
{
    public int score;
    public UnityEvent powerUpEvent;
    private void OnTriggerEnter(Collider other)
    {
        score++;
        //++ is the c# equivalent of +=
        print(score);
        powerUpEvent.Invoke();
    }
}
