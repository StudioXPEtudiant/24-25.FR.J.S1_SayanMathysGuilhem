using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text123 : MonoBehaviour
{
    public Text coinsCountText;
    public Text woodCountText;
    public static Text123 instance;

    void Update()
    {
        coinsCountText.text = acha1.instance.CurrentCoins.ToString();
        woodCountText.text = acha1.instance.CurrentWood.ToString();
    }

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Debug.LogWarning("nn");
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
    }
}
