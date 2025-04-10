using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDeath : MonoBehaviour
{
    public int countDeath = 0;
    public int countR = 4;
    //public Text textQuete;
    public TextQuete TextQuete;
    public acha1 acha1;
    public bool timer = false;
    void Start()
    {
        countDeath = 0;
        countR = 4;
        //text.text = "tuer 4 cibles";
        TextQuete.Quetenb(0);
        timer = false;
    }

    public void CountDeathTKT(int count)
    {
        countDeath += 1;
        countR -= 1;
        if(countDeath >= 4 && timer == false)
        {
            timer = true;
            TextQuete.Quetenb(1);
            death4();
        }
    }

    void Update()
    {
        if (countDeath <= 3)
        {
            TextQuete.Quetenb(0);
        }
    }

    void death4 ()
    {
        acha1.AddCoins(100);
        TextQuete.Quetenb(1);
    }
}
//faire en sorte que le texte reste dynamique mais que le death4 de ses mort soit appeler une fois
