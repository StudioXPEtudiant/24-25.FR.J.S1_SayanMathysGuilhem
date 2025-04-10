using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WoodTransfer : MonoBehaviour
{
    public Text woodCountText;
    public int addwood;

    void Start()
    {
        Gamemanger.Instance.woodCount = 0; // Initialiser woodCount si nécessaire
    }

    void Update()
    {
        woodCountText.text = Gamemanger.Instance.woodCount.ToString();
    }

    public void AddWood(int amount)
    {
        Gamemanger.Instance.woodCount += amount;
    }
}

