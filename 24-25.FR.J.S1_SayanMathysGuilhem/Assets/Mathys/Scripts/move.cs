using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Animation animations;

    public float walkSpeed;
    public float runSpeed;
    public float turnSpeed;

    public string imputFront;
    public string imputBack;
    public string imputLeft;
    public string imputRight;

    public Vector3 jumSpeed;
    CapsuleCollider PlayerCollider;

    void Start() 
    { 
        animations = gameObject.GetComponent<Animation>();
        PlayerCollider = gameObject.GetComponent<CapsuleCollider>();
    }


    void Update()
    {
        if (Input.GetKey(imputFront))
        {
            transform.Translate(0, 0, walkSpeed * Time.deltaTime);
            animations.Play("walk");
        }
        
        if (Input.GetKey(imputBack))
        {
            transform.Translate(0, 0, -(walkSpeed / 2) * Time.deltaTime);
           animations.Play("walk");
        }
            
        if (Input.GetKey(imputLeft))
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }    

        if (Input.GetKey(imputRight))
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0); 
        }
    }
}
