using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftArrow : MonoBehaviour
{   
    [SerializeField] GameObject Rarrow1;
    [SerializeField] GameObject Larrow1;
    [SerializeField] GameObject icon1;
    [SerializeField] GameObject Rarrow2;
    [SerializeField] GameObject Larrow2;
    [SerializeField] GameObject icon2;
    [SerializeField] GameObject Rarrow3;
    [SerializeField] GameObject Larrow3;
    [SerializeField] GameObject icon3;

    void Start()
    {
        Rarrow1.SetActive (true);
        Larrow1.SetActive (true);
        icon1.SetActive (true);
        Rarrow2.SetActive (false);
        Larrow2.SetActive (false);
        icon2.SetActive (false);
        Rarrow3.SetActive (false);
        Larrow3.SetActive (false);
        icon3.SetActive (false);
    }

    public void rightarrow1()
    {
        Rarrow1.SetActive (false);
        Larrow1.SetActive (false);
        icon1.SetActive (false);
        Rarrow2.SetActive (true);
        Larrow2.SetActive (true);
        icon2.SetActive (true);
    }

    public void rightarrow2()
    {
        Rarrow2.SetActive (false);
        Larrow2.SetActive (false);
        icon2.SetActive (false);
        Rarrow3.SetActive (true);
        Larrow3.SetActive (true);
        icon3.SetActive (true);
    }

    public void rightarrow3()
    {
        Rarrow3.SetActive (false);
        Larrow3.SetActive (false);
        icon3.SetActive (false);
        Rarrow1.SetActive (true);
        Larrow1.SetActive (true);
        icon1.SetActive (true);
    }

    public void leftarrow1()
    {
        Rarrow1.SetActive (false);
        Larrow1.SetActive (false);
        icon1.SetActive (false);
        Rarrow3.SetActive (true);
        Larrow3.SetActive (true);
        icon3.SetActive (true);
    }

    public void leftarrow3()
    {
        Rarrow3.SetActive (false);
        Larrow3.SetActive (false);
        icon3.SetActive (false);
        Rarrow2.SetActive (true);
        Larrow2.SetActive (true);
        icon2.SetActive (true);
    }

    public void leftarrow2()
    {
        Rarrow2.SetActive (false);
        Larrow2.SetActive (false);
        icon2.SetActive (false);
        Rarrow1.SetActive (true);
        Larrow1.SetActive (true);
        icon1.SetActive (true);
    }
}