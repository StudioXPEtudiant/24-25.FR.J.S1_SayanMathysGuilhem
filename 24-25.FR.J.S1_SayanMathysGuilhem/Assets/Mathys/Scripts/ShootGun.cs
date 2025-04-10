using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    public Collider hitColliders;
    public float Cooldown = 0.5f;
    public ennemyH ennemyH;

    void Start()
    {
        
    }

    void Update()
    {
        Cooldown -= Time.deltaTime;
        if(Cooldown <= 0)
        {
            if(Input.GetMouseButton(0))
            {
                Debug.Log("bouton");
                if(hitColliders.CompareTag("ennemy"))
                {
                    Debug.Log("tir reussi");
                    ennemyH.life -= 10;
                }
                Cooldown = 0.5f;
            }
        }
    }
}
