using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOffButton : MonoBehaviour
{
    public GameObject music;
    public bool musicActiv = true;
    
    void Start()
    {
        music = GameObject.FindGameObjectWithTag("music");
        
        
    }

  public void musicPause()
    {
        if (PlayerPrefs.GetInt("Audios") == 0)
        {
            PlayerPrefs.SetInt("Audios", 1);
            AudioListener.volume = 0;
 
        }
        else if (PlayerPrefs.GetInt("Audios") == 1)
        {
            PlayerPrefs.SetInt("Audios", 0);
            AudioListener.volume = 1;
           
        }    
         
    }

 
}
