using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chestQuete : MonoBehaviour
{
    [SerializeField] GameObject chest;
    public TextQuete textQuete;
    public CountDeath countR;
    public Collider collider;
    public acha1 acha1;

    void Start()
    {
        chest.SetActive(false);
    }

    void Update()
    {
        if (countR.countDeath >= 4)
        {
            chest.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            acha1.AddCoins(100);
            textQuete.Quetenb(2);
            Destroy(chest);
        }
    }
}
