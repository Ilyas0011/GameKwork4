using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2 : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Texture2D cursorRedTexture;
    public Texture2D cursorYellowTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public Sprite[] sprites = new Sprite[24];
    public Sprite[] yellowSprite = new Sprite[24];
    public Image[] m_Image = new Image[24];

    public int colour = 0;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.SetCursor(cursorTexture, Vector2.zero, cursorMode);
    }

    public void Paint(int i)
    {
        if (colour == 1)
        {

            m_Image[i].GetComponent<Image>().sprite = sprites[i];

        }
        else if (colour == 2)
        {

            m_Image[i].GetComponent<Image>().sprite = yellowSprite[i];
        }
    }

    public void ApplyRed()
    {
        Cursor.SetCursor(cursorRedTexture, Vector2.zero, cursorMode);
        colour = 1;
    }

    public void Checking()
    {

        int redFlower = 0, yellFlower = 0, redPear = 0, yellPear = 0, redPepper = 0, yellPepper = 0, redLadybug = 0, yellLadybug = 0;
        int General = 0;

        for (int i = 0; i < 9; i++)
        {
            if (m_Image[i].GetComponent<Image>().sprite == sprites[i])
            {
                redFlower++;
            }
            if (m_Image[i].GetComponent<Image>().sprite == yellowSprite[i])
            {
                yellFlower++;
            }

        }
        for (int i = 9; i < 16; i++)
        {
            if (m_Image[i].GetComponent<Image>().sprite == sprites[i])
            {
                redPear++;
            }
            if (m_Image[i].GetComponent<Image>().sprite == yellowSprite[i])
            {
                yellPear++;
            }
        }
        for (int i = 16; i < 19; i++)
        {
            if (m_Image[i].GetComponent<Image>().sprite == sprites[i])
            {
                redPepper++;
            }
            if (m_Image[i].GetComponent<Image>().sprite == yellowSprite[i])
            {
                yellPepper++;
            }
        }
        for (int i = 19; i < 24; i++)
        {
            if (m_Image[i].GetComponent<Image>().sprite == sprites[i])
            {
                redLadybug++;
            }
            if (m_Image[i].GetComponent<Image>().sprite == yellowSprite[i])
            {
                yellLadybug++;
            }
        }

        if (redFlower - yellFlower == 1)
        {


            General++;
        }
        if (redPear - yellPear == 1)
        {


            General++;
        }
        if (redPepper - yellPepper == 1)
        {


            General++;
        }
        if (redLadybug - yellLadybug == 1)
        {


            General++;
        }


        if (General == 4)
        {
            anim.Play("Correctly");

        }
        else
        {

            anim.Play("Mistake");
        }

    }

    public void ApplyYellow()
    {
        Cursor.SetCursor(cursorYellowTexture, Vector2.zero, cursorMode);
        colour = 2;
    }
}
