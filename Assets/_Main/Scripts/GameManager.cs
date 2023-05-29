using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    #region _VARIABLES
    public string autoScene;
    [HideInInspector] public AudioSource audioVO;
    #endregion

    #region _UNITY FUNCTION
    void Start()
    {
        audioVO = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(!audioVO.isPlaying)
        {
#if UNITY_EDITOR
            Debug.LogWarning("Successful move to scene: " + autoScene);
#endif
            SceneManager.LoadScene(autoScene);
        }
    }
    #endregion

    #region _PUBLIC FUNCTION
    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitTour()
    {
        Application.Quit();
    }
    #endregion
}
