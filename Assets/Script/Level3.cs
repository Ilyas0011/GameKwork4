using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3 : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Texture2D cursorGreen;
    public Texture2D cursorRed;
    public Texture2D cursorTurquoise;
    public Texture2D cursorYellow;
    public Texture2D cursorBlue;
    public Texture2D cursorPink;
    public Texture2D cursorDarkRed;
    public Texture2D cursorBlack;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public Sprite[] sprites = new Sprite[9];
    
    public GameObject[] m_Image = new GameObject[6];

    public int colour = 0;

    Animator anim;
    

    

    public void Applycolour(int colourID)   //0 �����, 1 ������, 2 �������, 3 ���������, 4 Ƹ����, 5 �����, 6 �������, 7 Ҹ���-�������, 8 ׸����.
    {
         
        colour = colourID;
        switch(colourID)
        {
            case 1:
                Cursor.SetCursor(cursorGreen, Vector2.zero, cursorMode);
                break;
            case 2:
                Cursor.SetCursor(cursorRed, Vector2.zero, cursorMode);
                break;
            case 3:
                Cursor.SetCursor(cursorTurquoise, Vector2.zero, cursorMode);
                break;
            case 4:
                Cursor.SetCursor(cursorYellow, Vector2.zero, cursorMode);
                break;
            case 5:
                Cursor.SetCursor(cursorBlue, Vector2.zero, cursorMode);
                break;
            case 6:
                Cursor.SetCursor(cursorPink, Vector2.zero, cursorMode);
                break;
            case 7:
                Cursor.SetCursor(cursorDarkRed, Vector2.zero, cursorMode);
                break;
            case 8:
                Cursor.SetCursor(cursorBlack, Vector2.zero, cursorMode);
                break;
        }
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.SetCursor(cursorTexture, Vector2.zero, cursorMode);
    }

    public void Paint(int ObjectID)
    {
        m_Image[ObjectID].GetComponent<Image>().sprite = sprites[colour];
        m_Image[ObjectID].GetComponent<ObjectColorId>().ObjectColour = colour;
    }

    public void Checking()
    {
        var Image0 = m_Image[0].GetComponent<ObjectColorId>().ObjectColour; //������� �1
        var Image1 = m_Image[1].GetComponent<ObjectColorId>().ObjectColour; //������� �2
        var Image2 = m_Image[2].GetComponent<ObjectColorId>().ObjectColour; //������� �3
        var Image3 = m_Image[3].GetComponent<ObjectColorId>().ObjectColour; //������� �4
        var Image4 = m_Image[4].GetComponent<ObjectColorId>().ObjectColour; //������� �5
        var Image5 = m_Image[5].GetComponent<ObjectColorId>().ObjectColour; //������� �6


        bool condition = Image0 == 2  // ����� 0 �����, 1 ������, 2 �������, 3 ���������, 4 Ƹ����, 5 �����, 6 �������, 7 Ҹ���-�������, 8 ׸����.
            && Image4 == 5
            && Image2 == Image3
            && Image2 != 2
            && Image2 != 5
            && Image2 != 0
            && Image1 == Image5
            && Image1 != 2
            && Image1 != 5
            && Image1 != 0
            && Image1 != Image2;
       
            
            
            
        if (condition)
        {


            anim.Play("Correctly");

        }
        else
        {

            anim.Play("Mistake");
        }

    }
}
