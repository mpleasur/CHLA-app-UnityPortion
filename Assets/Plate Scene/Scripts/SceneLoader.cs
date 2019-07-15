using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //loads next scene
    public void sceneLoader(string sceneName)     {         SceneManager.LoadScene(sceneName);     } 
}
