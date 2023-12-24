using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrewievLevel : MonoBehaviour
{
    public int sceneID;
    [SerializeField] GameObject other;
    public GameObject AudioOff;
    public bool Back = false;
    public void Start()
    {
        sceneID = SceneManager.GetActiveScene().buildIndex;
        if(sceneID == 0)
        {
            Back = 1 == PlayerPrefs.GetInt("backInt");
            if(Back == false)
            {
                other.gameObject.SetActive(false);
                this.gameObject.SetActive(true);
                 
            }
            else if (Back == true)
            {
                this.gameObject.SetActive(false);
                other.gameObject.SetActive(true);

            }
            PlayerPrefs.SetInt("backInt", 0);
        }
        else 
        {
            
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(true);

        }

    }
   public void offPrevievLevel()
    {

        this.gameObject.SetActive(false);
        other.gameObject.SetActive(true);

    }

    public void activatePrevievLevel()
    {

        this.gameObject.SetActive(true);
        other.gameObject.SetActive(false);

    }

}
