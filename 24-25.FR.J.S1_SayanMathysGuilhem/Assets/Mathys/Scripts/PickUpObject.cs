using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
   public acha1 Acha1;

   private void OnTriggerEnter(Collider collision)
   {
      if (collision.CompareTag("Player"))
      {      
         moi.instance.AddCoins(1);
         Destroy(gameObject);
      }
      if (collision.CompareTag("Player"))
      {         
         Debug.LogWarning("sa marche");
         Acha1.AddWood(1); // Correct class name
         Destroy(gameObject);
      }
   }
}
