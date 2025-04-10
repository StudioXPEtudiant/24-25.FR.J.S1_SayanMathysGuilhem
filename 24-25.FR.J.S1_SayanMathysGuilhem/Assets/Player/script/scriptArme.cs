using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptArme : MonoBehaviour
{
    public Transform BulletSpawn;
    public GameObject bulletprefab;
    public float bulletSpeed = 10;
    public float bulletcharge = 20;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public float currentBullet = 10;
    public float ReoladBullet = 3f;
    public float maxreload = 10;
    //private float minbullet = 0;
    public float nbBullet = 1;
    private float Cooldown = 0f;
    public float CoolDownReload = 2f;

    void Update()
    {
        Cooldown -= Time.deltaTime;
        if(Cooldown <= 0)
        {
            if(Input.GetMouseButton(0))
            {
               // if(currentBullet > minbullet)
                {
                  //  if(fireCountdown <= 0f)
                    //{
                        Shoot();
                        fireCountdown =1 / fireRate;
                        var bullet = Instantiate(bulletprefab, BulletSpawn.position, BulletSpawn.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = BulletSpawn.forward * bulletSpeed;
                       // currentBullet -= nbBullet;
                        //ReoladBullet -= Time.deltaTime;
                   // }
                }
            }
            fireCountdown -= Time.deltaTime;

            if(Input.GetKeyDown(KeyCode.R))
            {
               // currentBullet =+ maxreload;
                Cooldown = CoolDownReload;
            }
        }
    }

    void Shoot()
    {
        Debug.Log("tir_yes");
        //Cooldown = 1f;
    }
}
