using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Painting : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Texture2D cursorRedTexture;
     public Texture2D cursorYellowTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public Sprite[] sprites = new Sprite[25];
    public Sprite[] yellowSprite = new Sprite[25];
    public Image[] m_Image = new Image[25];

    public int colour = 0;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.SetCursor(cursorTexture, Vector2.zero, cursorMode);
    }

    public void Paint(int i)
    {
         if(colour == 1)
         {

            m_Image[i].GetComponent<Image>().sprite = sprites[i];

         }else if(colour == 2)
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

   
            int redApple = 0;
            int yellApple = 0;
            int redBall = 0;
            int yellBall = 0;
            int redButt = 0;
            int yellButt = 0;
            int redLeaves = 0;
            int yellowLeaves = 0;

            int General = 0;

            for(int i = 0; i < 5; i++)
            {
                  if( m_Image[i].GetComponent<Image>().sprite == sprites[i])
                  {
                         redApple++;
                  }
                  if( m_Image[i].GetComponent<Image>().sprite == yellowSprite[i])
                  {
                         yellApple++;
                  }
                  
            }
            for(int i = 5; i < 8; i++)
            {
                  if( m_Image[i].GetComponent<Image>().sprite == sprites[i])
                  {
                         redBall++;
                  }
                  if( m_Image[i].GetComponent<Image>().sprite == yellowSprite[i])
                  {
                         yellBall++;
                  }
            }
            for(int i = 8; i < 15; i++)
            {
                  if( m_Image[i].GetComponent<Image>().sprite == sprites[i])
                  {
                         redButt++;
                  }
                  if( m_Image[i].GetComponent<Image>().sprite == yellowSprite[i])
                  {
                         yellButt++;
                  }
            }
            for(int i = 15; i < 24; i++)
            {
                  if( m_Image[i].GetComponent<Image>().sprite == sprites[i])
                  {
                         redLeaves++;
                  }
                  if( m_Image[i].GetComponent<Image>().sprite == yellowSprite[i])
                  {
                         yellowLeaves++;
                  }
            }
     
            if (redApple - yellApple == 1)
            {
                    
                 
                   General++;
            }
            if (redBall - yellBall == 1)
            {
                  
                   
                   General++;
            }
            if (redButt - yellButt == 1)
            {
                   
                  
                   General++;
            }
            if (redLeaves - yellowLeaves == 1)
            {
                    
              
                   General++;
            }


            if (General == 4)
            {
                  anim.Play("Correctly");
                
            }else
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
