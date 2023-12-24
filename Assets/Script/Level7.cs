using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Level7 : MonoBehaviour
{
    public Texture2D[] cursorTexture = new Texture2D[9];


    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public Sprite[] sprites = new Sprite[24];

    public GameObject[] cube = new GameObject[24];

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

    public void PaintCube0()
    {
        cube[0].GetComponent<Image>().sprite = sprites[colour];
 
        cube[0].GetComponent<ObjectColorId>().ObjectColour = colour;


    }
    public void PaintCube2()
    {
        colour += 17;
        cube[2].GetComponent<Image>().sprite = sprites[colour];
        colour -= 17;
        cube[2].GetComponent<ObjectColorId>().ObjectColour = colour;
    }
    public void PaintCube1()
    {

        colour += 9;
        cube[1].GetComponent<Image>().sprite = sprites[colour];
        colour -= 9;
        cube[1].GetComponent<ObjectColorId>().ObjectColour = colour;
    }

    public void Checking()
    {

        if (cube[0].GetComponent<ObjectColorId>().ObjectColour == 5
            && cube[1].GetComponent<ObjectColorId>().ObjectColour == 2
              && cube[2].GetComponent<ObjectColorId>().ObjectColour == 1)
        {

            anim.Play("Correctly");
        }
        else
        {
            anim.Play("Mistake");
        }
    }
}
