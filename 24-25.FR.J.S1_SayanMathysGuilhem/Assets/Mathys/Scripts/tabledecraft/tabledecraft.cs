using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tabledecraft : MonoBehaviour
{
    public string Scenename;
    [SerializeField] public acha1 Acha11;
    [SerializeField] public GameObject croshair;
    //[SerializeField] private KeyCode ToucheCraft = KeyCode.C;
    private static tabledecraft instance = null;

    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.C))
            {            
                if(Acha11.CurrentWood >= 1)
                {
                    Debug.LogWarning("CRAFT");
                    Acha11.AddWood(0);
                    SceneManager.LoadScene(Scenename);
                }
                else
                {
                    Debug.LogWarning("non");
                }
            }
        }
    }

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
