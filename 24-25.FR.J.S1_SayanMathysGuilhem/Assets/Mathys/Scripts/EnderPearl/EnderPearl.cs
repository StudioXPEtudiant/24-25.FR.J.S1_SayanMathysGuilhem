using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnderPearl : MonoBehaviour
{
    public Transform EndaerPearleSapwner;
    public GameObject EndaerPearlePrefab;
    public Transform player;
    public Transform enderpearl;
    public float maxreload = 10;
    public float nbBullet = 1;
    public float currentBullet = 10;
    public float CoolDownReload = 2f;
    public float bulletSpeed = 10;
    public float reload = 5f;
    [SerializeField] GameObject image;


    void Start()
    {

    }

    void Update()
    {
        reload -= Time.deltaTime;
        if(reload <= 0)
        {
            image.SetActive(true);
            if(Input.GetKeyDown(KeyCode.F))
            {
                var bullet = Instantiate(EndaerPearlePrefab, EndaerPearleSapwner.position, EndaerPearleSapwner.rotation);
                bullet.GetComponent<Rigidbody>().velocity = EndaerPearleSapwner.forward * bulletSpeed;
                currentBullet -= nbBullet;
                reload = 5f;
                image.SetActive(false);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("SC enderpearl");
        if (collision.gameObject.tag == "Ground")//
        {
            Debug.Log("Enderpearl teleport");
            //player.position = enderpearl.position;
        }
    }
}
