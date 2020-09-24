
using System;
using UnityEngine;

public class PowerUpTwo : MonoBehaviour
{
   public int value;
   //Value is a generic word that we can use it in more ways than one. 

   private void OnTriggerEnter(Collider other)
   {
      value++;
   }
}
