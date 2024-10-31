using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int CurrentCoins;
    public int coinsCount;
    public Text coinsCountText;

    public static Inventory instance;

    void Start()
    {
        CurrentCoins = coinsCount;
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
    
}
