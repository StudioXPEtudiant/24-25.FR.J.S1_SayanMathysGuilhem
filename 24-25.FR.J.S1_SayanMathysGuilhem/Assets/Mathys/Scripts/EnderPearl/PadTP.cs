using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadTP : MonoBehaviour
{
    public Transform player,  destiniation;
    public GameObject playerG;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerG.SetActive(false);
            player.position = destiniation.position;
            playerG.SetActive(true);
        }
    }
}
