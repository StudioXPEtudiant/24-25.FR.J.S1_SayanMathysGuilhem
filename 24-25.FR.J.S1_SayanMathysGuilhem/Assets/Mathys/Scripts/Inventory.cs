using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int CurrentCoins;
    public int CurrentWood;
    public int coinsCount;
    public int woodCount;
    public Text coinsCountText;
    public Text woodCountText;
    public Text123 text;

    public static Inventory instance;

    void Start()
    {
        CurrentCoins = coinsCount;
        CurrentWood = woodCount;
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

    public void AddCoins(int count)
    {
        CurrentCoins += count;
        coinsCount += count;
        coinsCountText.text = coinsCount.ToString();
    }

    public void AddWood(int count)
    {
        CurrentWood += count;
        woodCount += count;
        woodCountText.text = woodCount.ToString();
    }
    
}
