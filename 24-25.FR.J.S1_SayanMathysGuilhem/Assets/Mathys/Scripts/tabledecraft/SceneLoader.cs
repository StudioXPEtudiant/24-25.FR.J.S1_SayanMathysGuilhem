using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string Scenename;

    public void Sceneload()
    {
        SceneManager.LoadScene(Scenename);
    }
    
}
