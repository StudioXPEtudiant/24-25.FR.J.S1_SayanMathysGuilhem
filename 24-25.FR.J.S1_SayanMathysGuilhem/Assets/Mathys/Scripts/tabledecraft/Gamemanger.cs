using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanger : MonoBehaviour
{
    public static Gamemanger Instance { get; private set; }

    public int woodCount;
    private acha1 acha1Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //private void Update()
    //{
        //acha1Instance = FindObjectOfType<acha1>();
        //if (acha1Instance != null)
        //{
        //    woodCount = acha1Instance.UpdateWoodCount();
        //}
    //}
}
