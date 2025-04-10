using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodsystem : MonoBehaviour
{
    public static int woodCount = 0;
    public acha1 Acha1;

    public static void AddWood(int amount)
    {
        woodCount += amount;
        Debug.LogWarning("Wood collected: " + woodCount);
    }

    public static int GetWoodCount()
    {
        return woodCount;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {         
            Debug.LogWarning("sa marche");
            Acha1.AddWood(1); // Correct class name
            Destroy(gameObject);
        }
    }
}