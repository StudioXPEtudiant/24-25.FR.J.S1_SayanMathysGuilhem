using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acha1 : MonoBehaviour
{
    [SerializeField] GameObject shopitem;
    [SerializeField] GameObject shopitem1;
    [SerializeField] GameObject shopitem2;
    [SerializeField] GameObject shopitem3;
    [SerializeField] GameObject shopitem4;
    [SerializeField] GameObject j1;
    [SerializeField] GameObject j2;
    [SerializeField] GameObject j3;
    [SerializeField] GameObject gun3;
    [SerializeField] GameObject gun2;
    [SerializeField] GameObject gun1;
    //[SerializeField] GameObject nn;
    [SerializeField] GameObject a1;
    [SerializeField] GameObject a2;
    [SerializeField] GameObject a3;
    [SerializeField] GameObject a4;
    [SerializeField] GameObject a5;
    public int price;
    public int price1;
    public int price2;
    public int price3;
    public int price4;
    public int CurrentCoins;
    public int coinsCount;
    public int addcoins;
    public Text coinsCountText;

    public void Acha()
    {
        if(CurrentCoins >= price)
        {
            shopitem.SetActive(false);
            j1.SetActive(false);
            j2.SetActive(true);
            j3.SetActive(false);
            a1.SetActive(true);
            CurrentCoins -= price;
            coinsCountText.text = CurrentCoins.ToString();    
        }
        else
        {
            Debug.LogWarning ("non");
            //nn.SetActive(true);
        }
    }

    public void Acha1()
    {
        if(CurrentCoins >= price1)
        {
            shopitem1.SetActive(false);
            j1.SetActive(false);
            j2.SetActive(false);
            j3.SetActive(true);
            a2.SetActive(true);
            CurrentCoins -= price1;
            coinsCountText.text = CurrentCoins.ToString();    
        }
        else
        {
            Debug.LogWarning ("non");
            //nn.SetActive(true);
        }
    }

    public void Acha2()
    {
        if(CurrentCoins >= price2)
        {
            shopitem2.SetActive(false);
            gun2.SetActive(false);
            gun1.SetActive(true);
            gun3.SetActive(false);
            a3.SetActive(true);
            CurrentCoins -= price2;
            coinsCountText.text = CurrentCoins.ToString();    
        }
        else
        {
            Debug.LogWarning ("non");
            //nn.SetActive(true);
        }
    }

    public void Acha3()
    {
        if(CurrentCoins >= price3)
        {
            shopitem3.SetActive(false);
            gun1.SetActive(false);
            gun2.SetActive(true);
            gun3.SetActive(false);
            a4.SetActive(true);
            CurrentCoins -= price2;
            coinsCountText.text = CurrentCoins.ToString();    
        }
        else
        {
            Debug.LogWarning ("non");
            //nn.SetActive(true);
        }
    }

    public void Acha4()
    {
        if(CurrentCoins >= price4)
        {
            shopitem4.SetActive(false);
            gun1.SetActive(false);
            gun2.SetActive(false);
            gun3.SetActive(true);
            a5.SetActive(true);
            CurrentCoins -= price4;
            coinsCountText.text = CurrentCoins.ToString();    
        }
        else
        {
            Debug.LogWarning ("non");
            //nn.SetActive(true);
        }
    }

    void Update()
    {
        //nn.SetActive(false);
        return;
    }

    void Start()
    {
        shopitem.SetActive(true);
        gun1.SetActive(false);
        j1.SetActive(true);
        j2.SetActive(false);
        j3.SetActive(false);
        gun2.SetActive(false);
        gun1.SetActive(false);
        gun3.SetActive(false);
        //nn.SetActive(false);
        Debug.LogWarning ("Acheter");
        a1.SetActive(false);
        a2.SetActive(false);
        a3.SetActive(false);
        a4.SetActive(false);
        a5.SetActive(false);
    }

    public void select1()
    {
        j2.SetActive(true);
        j3.SetActive(false);
    }

    public void select2()
    {
        j2.SetActive(false);
        j3.SetActive(true);
    }

    public void select3()
    {
        gun1.SetActive(true);
        gun2.SetActive(false);
        gun3.SetActive(false);
    }

    public void select4()
    {
        gun1.SetActive(false);
        gun2.SetActive(true);
        gun3.SetActive(false);
    }

    public void select5()
    {
        gun1.SetActive(false);
        gun2.SetActive(false);
        gun3.SetActive(true);
    }
    
    public void AddCoins(int count)
    {
        CurrentCoins += count;
        addcoins += count;
        coinsCountText.text = CurrentCoins.ToString();
    }
}