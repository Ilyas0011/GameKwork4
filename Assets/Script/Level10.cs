using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level10 : MonoBehaviour
{
    public Sprite[] sprites = new Sprite[2];
    public GameObject[] objects = new GameObject[12];
    Animator anim;
    public int sceneID;

    void Start()
    {
        anim = GetComponent<Animator>();
        sceneID = SceneManager.GetActiveScene().buildIndex;
    }

    public void Color(int id)
    {
       if(objects[id].GetComponent<ObjectColorId>().ObjectColour == 1)
        {

            objects[id].GetComponent<Image>().sprite = sprites[3];
            objects[id].GetComponent<ObjectColorId>().ObjectColour = 0;

        }else
        {  
            objects[id].GetComponent<Image>().sprite = sprites[0];
      
            objects[id].GetComponent<ObjectColorId>().ObjectColour = 1;
        }
    }
    public void Shape(int id)
    {

        if (objects[id].GetComponent<ObjectColorId>().ObjectColour == 1)
        {

            objects[id].GetComponent<Image>().sprite = sprites[4];
            objects[id].GetComponent<ObjectColorId>().ObjectColour = 0;

        }
        else
        {
            objects[id].GetComponent<Image>().sprite = sprites[1];

            objects[id].GetComponent<ObjectColorId>().ObjectColour = 1;
        }
      
    }
    public void Size(int id)
    {

        if (objects[id].GetComponent<ObjectColorId>().ObjectColour == 1)
        {

            objects[id].GetComponent<Image>().sprite = sprites[5];
            objects[id].GetComponent<ObjectColorId>().ObjectColour = 0;

        }
        else
        {
            objects[id].GetComponent<Image>().sprite = sprites[2];

            objects[id].GetComponent<ObjectColorId>().ObjectColour = 1;
        }

    }


    public void Checking()
    {
        switch (sceneID)
        { 
            case 10:
            if (objects[0].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[1].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[2].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[3].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[4].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[5].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[6].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[7].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[8].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[9].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[10].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[11].GetComponent<ObjectColorId>().ObjectColour == 1)
            {
                anim.Play("Correctly");
            }
            else
            {
                anim.Play("Mistake");
            }
            break;
            case 12:
            if (objects[0].GetComponent<ObjectColorId>().ObjectColour == 0
               && objects[1].GetComponent<ObjectColorId>().ObjectColour == 1
               && objects[2].GetComponent<ObjectColorId>().ObjectColour == 1
               && objects[3].GetComponent<ObjectColorId>().ObjectColour == 0
               && objects[4].GetComponent<ObjectColorId>().ObjectColour == 0
               && objects[5].GetComponent<ObjectColorId>().ObjectColour == 1
               && objects[6].GetComponent<ObjectColorId>().ObjectColour == 1
               && objects[7].GetComponent<ObjectColorId>().ObjectColour == 1
               && objects[8].GetComponent<ObjectColorId>().ObjectColour == 1
               && objects[9].GetComponent<ObjectColorId>().ObjectColour == 1
               && objects[10].GetComponent<ObjectColorId>().ObjectColour == 0
               && objects[11].GetComponent<ObjectColorId>().ObjectColour == 1)
            {
                anim.Play("Correctly");
            }
            else
            {
                anim.Play("Mistake");
            }
            break;
            case 14:
            if (objects[0].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[1].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[2].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[3].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[4].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[5].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[6].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[7].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[8].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[9].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[10].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[11].GetComponent<ObjectColorId>().ObjectColour == 1)
            {
                anim.Play("Correctly");
            }
            else
            {
                anim.Play("Mistake");
            }
            break;
            case 16:
            if (objects[0].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[1].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[2].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[3].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[4].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[5].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[6].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[7].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[8].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[9].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[10].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[11].GetComponent<ObjectColorId>().ObjectColour == 0)
            {
                anim.Play("Correctly");
            }
            else
            {
                anim.Play("Mistake");
            }
            break;
            case 18:
            if (objects[0].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[1].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[2].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[3].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[4].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[5].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[6].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[7].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[8].GetComponent<ObjectColorId>().ObjectColour == 0
              && objects[9].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[10].GetComponent<ObjectColorId>().ObjectColour == 1
              && objects[11].GetComponent<ObjectColorId>().ObjectColour == 1)
            {
                anim.Play("Correctly");
            }
            else
            {
                anim.Play("Mistake");
            }
            break;
            case 20:
            if (objects[0].GetComponent<ObjectColorId>().ObjectColour == 1
             && objects[1].GetComponent<ObjectColorId>().ObjectColour == 1
             && objects[2].GetComponent<ObjectColorId>().ObjectColour == 0
             && objects[3].GetComponent<ObjectColorId>().ObjectColour == 1
             && objects[4].GetComponent<ObjectColorId>().ObjectColour == 1
             && objects[5].GetComponent<ObjectColorId>().ObjectColour == 1
             && objects[6].GetComponent<ObjectColorId>().ObjectColour == 1
             && objects[7].GetComponent<ObjectColorId>().ObjectColour == 1
             && objects[8].GetComponent<ObjectColorId>().ObjectColour == 0
             && objects[9].GetComponent<ObjectColorId>().ObjectColour == 0
             && objects[10].GetComponent<ObjectColorId>().ObjectColour == 0
             && objects[11].GetComponent<ObjectColorId>().ObjectColour == 0)
            {
                anim.Play("Correctly");
            }
            else
            {
                anim.Play("Mistake");
            }
            break;
        }
    }
}
