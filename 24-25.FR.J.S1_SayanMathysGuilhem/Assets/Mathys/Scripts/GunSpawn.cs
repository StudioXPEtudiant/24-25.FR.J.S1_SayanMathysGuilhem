using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpawn : MonoBehaviour
{
    [SerializeField] GameObject gun1;
    [SerializeField] GameObject gun2;
    [SerializeField] GameObject gun3;

    void Start()
    {
        gun1.SetActive (false);
        gun2.SetActive (false);
        gun3.SetActive (false);
    }
}
