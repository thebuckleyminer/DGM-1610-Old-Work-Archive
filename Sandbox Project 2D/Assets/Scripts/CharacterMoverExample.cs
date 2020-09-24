using System;
using UnityEngine;

public class CharacterMoverExample : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 moveDirection;

    private void Update()
    {
        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);
    }
}
