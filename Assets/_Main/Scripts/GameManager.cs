using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region _UNITY FUNCTION
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    #region _PUBLIC FUNCTION
    public void MainMenu_ChangeSceneTo(string changeSceneTo)
    {
        SceneManager.LoadScene(changeSceneTo);
    }
    #endregion
}
