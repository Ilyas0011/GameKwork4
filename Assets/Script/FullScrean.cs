using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScrean : MonoBehaviour
{
     
   

    public void WindowScreenButton()
    {

        if (Screen.fullScreen = !Screen.fullScreen)
        {
            Screen.SetResolution(Screen.width * 2, Screen.height * 2, true);
        }
        else
        {
            Screen.SetResolution(Screen.width / 2, Screen.height / 2, false);
            
        }


    }

   
}
