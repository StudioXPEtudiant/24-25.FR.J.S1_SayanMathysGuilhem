using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shopopen : MonoBehaviour
{
    [SerializeField] private KeyCode openshop = KeyCode.E;
    [SerializeField] GameObject Shop;
    private bool touchactive;

    void Update()
    {
        if (Input.GetKeyDown(openshop))
        {
            if (touchactive == false)
            {
                touchactive = true;
                Shop.SetActive (false);
            }
            else
            {
                touchactive = false;
                Shop.SetActive (true);
            }
        }
    }
}
