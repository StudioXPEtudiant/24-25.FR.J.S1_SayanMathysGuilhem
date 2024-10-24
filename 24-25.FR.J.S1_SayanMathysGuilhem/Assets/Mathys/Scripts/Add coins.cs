using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addcoins : MonoBehaviour
{
    public int addcoins;
    public int CurrentCoins;

    public void AddCoins(int count)
    {
        CurrentCoins += count;
        addcoins += count;
    }
}
