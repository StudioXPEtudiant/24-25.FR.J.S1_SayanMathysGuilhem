using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimScript : MonoBehaviour
{
    public GameObject Gun;

    // Start is called before the first frame update
    void Start()
    {
        Gun.GetComponent<Animator>().Play("Default");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Gun.GetComponent<Animator>().Play("Aim");
        }
        if(Input.GetMouseButtonUp(1))
        {
            Gun.GetComponent<Animator>().Play("Default");
        }
    }
}