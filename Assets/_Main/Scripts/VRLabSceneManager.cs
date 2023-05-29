using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VRLabSceneManager : MonoBehaviour
{
    #region _VARIABLES
    public string nextScene;
    public string previousScene;
    #endregion

    #region _UNITY FUNCTION
    void Start()
    {
        
    }

    private void Update()
    {

    }
    #endregion

    #region _PUBLIC FUNCTION
    public void ChangeToPreviousScene()
    {
        SceneManager.LoadScene(previousScene);
    }

    public void ChangeToNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void ExitTour()
    {
        Application.Quit();
    }
    #endregion
}
