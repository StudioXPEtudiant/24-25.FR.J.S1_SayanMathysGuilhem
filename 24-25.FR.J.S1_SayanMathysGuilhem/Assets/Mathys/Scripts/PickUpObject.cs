using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision.CompareTag("Player"))
     {
      moi.instance.AddCoins(1);
      Destroy(gameObject);
     }

    if (Input.GetKeyDown(KeyCode.J))
      {
      moi.instance.AddCoins(1);
      }
   }
}
