using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.WSA;

public class Room1 : MonoBehaviour
{
    public UnityEvent oppenDoor;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            oppenDoor.Invoke();
            Debug.Log("voila");
        }
    }
    
    
}

    

  
