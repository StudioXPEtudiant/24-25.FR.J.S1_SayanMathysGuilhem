using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform BulletSpawn;
    public GameObject bulletprefab;
    public Animator animator;
    bool isTurning;
    public float bulletSpeed = 10;
    //public float bulletcharge = 20;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public float currentBullet = 10;
    public float ReoladBullet = 3f;
    public float maxreload = 10;
    private float minbullet = 0;
    public float nbBullet = 1;
    private float Cooldown = 0f;
    public float CoolDownReload = 2f;
    //private float CanShoot = 0;

    void Update()
    {
        Cooldown -= Time.deltaTime;
        if(Cooldown <= 0)
        {
                if(Input.GetMouseButton(0))
                {
                    if(currentBullet > minbullet)
                    {
                        if(fireCountdown <= 0f)
                        {
                            Shoot();
                            fireCountdown =1 / fireRate;
                            var bullet = Instantiate(bulletprefab, BulletSpawn.position, BulletSpawn.rotation);
                            bullet.GetComponent<Rigidbody>().velocity = BulletSpawn.forward * bulletSpeed;
                            currentBullet -= nbBullet;
                            //ReoladBullet -= Time.deltaTime;
                        }
                    }
                }
                fireCountdown -= Time.deltaTime;
            
                if(Input.GetKeyDown(KeyCode.R))
                {
                    animator.SetTrigger("reload");
                    currentBullet =+ maxreload;
                    Cooldown = CoolDownReload;
                    StartCoroutine(MyMethod());
                    //if(!isTurning)
                    //{
                    //    isTurning = true;
                    //}
                    //else
                    //{
                    //    animator.SetBool("reload", false);
                    //    isTurning = false;
                    //}
                }
        }

        if (currentBullet == 0)
        {
            currentBullet = 1000000;
        }
    }

    void Shoot()
    {
        Debug.Log("tir_yes");
        //Cooldown = 1f;
    }

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        isTurning = false;
        //GetComponent<Animator>().Play("reload");
        //CanShoot = 1;
    }

    IEnumerator MyMethod()
    {
		animator.CrossFade("reload",0.19f);
        yield return new WaitForSeconds(19);	
    }
}