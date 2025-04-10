using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemyH : MonoBehaviour
{
    public int life = 10;
    public acha1 Acha1;
    public CountDeath CountDeathGG;

    void Start()
    {
        
    }

    void Update()
    {
        if(life <= 0)
        {
            Acha1.AddCoins(1000);
            CountDeathGG.CountDeathTKT(1);
            Debug.Log("SC ennemyH");
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "balle")
        {
            life -= 1;
        }
    }
}
