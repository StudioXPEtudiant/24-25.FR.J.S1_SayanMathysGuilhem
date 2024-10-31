using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddC : MonoBehaviour
{
    public int addcoins;
    public int CurrentCoins;
    public Text coinsCountText;

    public void AddCoins(int count)
    {
        CurrentCoins += count;
        addcoins += count;
        coinsCountText.text = CurrentCoins.ToString();
    }
}
