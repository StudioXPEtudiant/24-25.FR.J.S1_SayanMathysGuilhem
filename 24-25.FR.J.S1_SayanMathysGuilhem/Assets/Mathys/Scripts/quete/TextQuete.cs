using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuete : MonoBehaviour
{
    public Text textQuete;
    public CountDeath countR;
    
    void Start()
    {
        
    }

    void Update()
    {

    }

    public void Quetenb(int count)
    {
        if (count == 0)
        {
            textQuete.text = "tuer" + countR.countR + "cibles";
        }
        else if (count == 1)
        {
            textQuete.text = "trouve le coffre cacher";
        }
        else if (count == 2)
        {
            textQuete.text = "2";
        }
       else if (count == 3)
        {
            textQuete.text = "3";
        }
        else if (count == 4)
        {
            textQuete.text = "KK";
       }
    }
}
