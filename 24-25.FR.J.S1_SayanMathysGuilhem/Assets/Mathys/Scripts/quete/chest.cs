using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    [SerializeField] GameObject chests;
    public CountDeath countR;

    void Start()
    {
        chests.SetActive(false);
    }

    void Update()
    {
        if (countR.countDeath >= 4)
        {
            chests.SetActive(true);
        }
    }
}
