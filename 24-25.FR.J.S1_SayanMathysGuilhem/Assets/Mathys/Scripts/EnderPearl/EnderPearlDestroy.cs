using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnderPearlDestroy : MonoBehaviour
{
    public float Timer = 99999f;
    public float Timer2 = 99999f;
    public Transform player , enderpearl;

    void OnCollisionEnter(Collision collision)
    {
        Timer = 0.1f;
        Timer2 = 0.127f;
        //player = GameObject.Find("FPCPlayer 1").transform;
        //enderpearl = GameObject.Find("EnderPearl").transform;
        //Debug.Log("SC EnderPearlDestroy");
        if (collision.gameObject.tag == "Ground")
        {
            player.transform.position = enderpearl.position;
            transform.Translate(player.position = enderpearl.position);
            //Debug.Log("Enderpearl teleport");
        }
    }

    void Update()
    {
        player = GameObject.Find("FPCPlayer 1").transform;
        Timer -= Time.deltaTime;
        Timer2 -= Time.deltaTime;
        if(Timer <= 0f)
        {   
            player.position = enderpearl.position;
            //yield return new WaitForSeconds(0.1f);
            if(Timer2 <= 0f)
            {
                Destroy(gameObject);
            }
            
        }
    }
}
 