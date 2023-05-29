using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VRLabNavigation : MonoBehaviour
{
    void Start()
    {
        
    }

    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitTour()
    {
        Application.Quit();
    }
}
