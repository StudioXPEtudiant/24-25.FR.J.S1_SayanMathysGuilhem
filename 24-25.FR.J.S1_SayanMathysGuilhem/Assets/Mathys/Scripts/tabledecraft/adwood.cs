using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adwood : MonoBehaviour
{
    public acha1 acha1;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            acha1.AddWood(100);
        }
    }
}
