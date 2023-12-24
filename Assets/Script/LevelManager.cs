using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    int sceneID;

    void Start()
    {

        sceneID = SceneManager.GetActiveScene().buildIndex;

    }


    public void OpenLevel(int levelid)
    {
        SceneManager.LoadScene(levelid);
    }


    public void OpenNextLevel()
    {
        SceneManager.LoadScene(sceneID + 1);
    }



    public void OpenMenu()
    {
        PlayerPrefs.SetInt("backInt", 1);
        SceneManager.LoadScene(0);
    }
}
