using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Level4 : MonoBehaviour
{
    public Texture2D[] cursorTexture = new Texture2D[9];
 

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public Sprite[] sprites = new Sprite[9];

    public GameObject[] car = new GameObject[6];

    public int colour = 0;

    Animator anim;




    public void Applycolour(int colourID)   //0 Серый, 1 Зелёный, 2 Красный, 3 Бирюзовый, 4 Жёлтый, 5 Синий, 6 Розовый, 7 Тёмно-красный, 8 Чёрный.
    {

        colour = colourID;
        Cursor.SetCursor(cursorTexture[colourID], Vector2.zero, cursorMode);
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.SetCursor(cursorTexture[0], Vector2.zero, cursorMode);
    }

    public void Paint(int ObjectID)
    {
        car[ObjectID].GetComponent<Image>().sprite = sprites[colour];
        car[ObjectID].GetComponent<ObjectColorId>().ObjectColour = colour;
    }

    public void Checking()
    {
        if(car[5].GetComponent<ObjectColorId>().ObjectColour == 2  
            && car[4].GetComponent<ObjectColorId>().ObjectColour == 5
            && car[2].GetComponent<ObjectColorId>().ObjectColour == car[3].GetComponent<ObjectColorId>().ObjectColour
            && car[2].GetComponent<ObjectColorId>().ObjectColour != car[0].GetComponent<ObjectColorId>().ObjectColour
            && car[2].GetComponent<ObjectColorId>().ObjectColour != 2
            && car[2].GetComponent<ObjectColorId>().ObjectColour != 5
            && car[0].GetComponent<ObjectColorId>().ObjectColour == car[1].GetComponent<ObjectColorId>().ObjectColour)
        {


            anim.Play("Correctly");
        }
        else
        {
            anim.Play("Mistake");
        }
    



    }
}
