using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingSystem : MonoBehaviour
{
    public acha1 Acha1;
    public const int count = 10;

    public void Craft()
    {
        if (Acha1.CurrentWood >= 4)
        {
            Debug.Log("CRAFT");
            Acha1.AddWood(-4);
            Acha1.AddCoins(100);
        }
        else
        {
            Debug.Log("Not enough wood to craft");
        }
    }

    void Start()
    {
        var gameObjects = new GameObject[count];
        var expectedTextMeshObjects = new TextMesh[count];
        Acha1 = FindFirstObjectByType<acha1> (FindObjectsInactive.Include);
    }

    void Update()
    {
        Debug.Log(Acha1 + " : " + Acha1.CurrentWood);
    }
}
