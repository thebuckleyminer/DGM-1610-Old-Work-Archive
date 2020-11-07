using System;
using UnityEngine;

public class SeptemberTwentyFourCharacterMover : MonoBehaviour
{
   public CharacterController controller;
   public float moveSpeed = 5f;
   
   
   private Vector3 moveDirection;

   private void Update()
   {
      var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
         
      moveDirection.Set(moveSpeedInput, 0, 0);

      var movement = moveDirection * Time.deltaTime;
      controller.Move(moveDirection * Time.deltaTime);
   }
   
}
