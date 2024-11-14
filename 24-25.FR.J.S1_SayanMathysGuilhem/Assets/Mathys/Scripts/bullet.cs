using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float life = 3;
    private float Cooldown = 1f;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);       
        Cooldown -= Time.deltaTime;
        Destroy(gameObject);

    }
    
}
