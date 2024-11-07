using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cible_script : MonoBehaviour
{
    public UnityEvent hidedébut;
    public UnityEvent coucoupascache;

    private void Start()
    {
        hidedébut.Invoke();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("balle"))
        {
            coucoupascache.Invoke();
        }
    }
}
