using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TShop : MonoBehaviour
{

    private KeyCode touches = KeyCode.E;
    [SerializeField] GameObject Shop;
    private bool touchactive;


    void Update()
    {
    
        if (Input.GetKeyDown(touches))
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
