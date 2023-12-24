using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level8 : MonoBehaviour
{


    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);

    }
    public void buttonClickWin ()
        {


        anim.Play("Correctly");
         }


    public void buttonClickFailed()
    {

        anim.Play("Mistake");
    }
}
