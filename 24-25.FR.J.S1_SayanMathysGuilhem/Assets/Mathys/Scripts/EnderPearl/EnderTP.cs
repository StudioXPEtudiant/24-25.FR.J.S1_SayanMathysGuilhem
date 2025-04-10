using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnderTP : MonoBehaviour
{
    public Transform player;
    public Transform enderpearl;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Ground"))
        {
            Debug.Log("Enderpearl teleport");
            player.position = enderpearl.position;
            transform.Translate(player.position = enderpearl.position);
        }
    }
}
