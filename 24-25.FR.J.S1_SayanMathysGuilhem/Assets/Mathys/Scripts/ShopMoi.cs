using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMoi : MonoBehaviour
{
    [SerializeField] GameObject ShopUI;
    [SerializeField] GameObject ButtonUI;
    
    void Start()
    {
        ShopUI.SetActive (false);
    }

    public void CloseShop()
    {
        ShopUI.SetActive (false);
       ButtonUI.SetActive (true);
    }

    public void OpenShop()
    {
        ShopUI.SetActive (true);
        ButtonUI.SetActive (false);
    }
}
