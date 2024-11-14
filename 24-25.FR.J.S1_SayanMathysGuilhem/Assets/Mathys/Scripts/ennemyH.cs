using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemyH : MonoBehaviour
{

    public float life = 10;
    public acha1 Acha1;

    void Start()
    {
        
    }

    void Update()
    {
        if(life <= 0)
        {
            Acha1.AddCoins(1000);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        life -= 1;
    }
}
