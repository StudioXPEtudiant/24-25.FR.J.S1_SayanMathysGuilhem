using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft : MonoBehaviour
{
    // faire le systeme du craft 
    [SerializeField] GameObject test;
    public acha1 Acha;

    void Start()
    {
        test.SetActive(false);
    }

    public void CraftWood()
    {
        if(Acha.CurrentWood >= 1)
        {
            Debug.LogWarning("CRAFTWood");
            test.SetActive(true);
        }
    }
}
