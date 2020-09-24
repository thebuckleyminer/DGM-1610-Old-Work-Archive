using System;
using UnityEngine;

public class SeptemberTwentyFourCharacterMover : MonoBehaviour
{
   public CharacterController controller;
   private Vector3 moveDirection;

   private void Update()
   {
      moveDirection.Set(5f, 0, 0);
      controller.Move(moveDirection * Time.deltaTime);
   }
   
}
