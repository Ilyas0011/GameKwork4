using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Number : MonoBehaviour
{

     TextMeshProUGUI TextMesh;
    public int numberLvl13 = 0;

    public void Start()
    {

          
            TextMesh = GetComponent<TextMeshProUGUI>();
       

    }

    public void addOne(int a)
    {

        a = Convert.ToInt32(TextMesh.text);

        a++;
        if (a == 10)
        {

            a = 0;

        }
        TextMesh.text = Convert.ToString(a);



    }


    public void addOne13lvl( )
    {



        numberLvl13++;
         
        if (numberLvl13 == 34)
        {

            numberLvl13 = 0;

        }

        switch (numberLvl13)    //À Á Â Ã Ä Å ¨ Æ Ç È É Ê Ë Ì Í Î Ï Ð Ñ Ò Ó Ô Õ Ö × Ø Ù Ú Û Ü Ý Þ ß
        {
            case 1:
                TextMesh.text = "À";
                break;
            case 2:
                TextMesh.text = "Á";
                break;
            case 3:
                TextMesh.text = "Â";
                 
                break;
            case 4:
                TextMesh.text = "Ã";
                break;
            case 5:
                TextMesh.text = "Ä";
                break;
            case 6:
                TextMesh.text = "Å";
                break;
            case 7:
                TextMesh.text = "¨";
                break;
            case 8:
                TextMesh.text = "Æ";
                break;
            case 9:
                TextMesh.text = "Ç";
                break;
            case 10:
                TextMesh.text = "È";
                break;
            case 11:
                TextMesh.text = "É";
                break;
            case 12:
                TextMesh.text = "Ê";
                break;
            case 13:
                TextMesh.text = "Ë";
                break;
            case 14:
                TextMesh.text = "Ì";
                break;
            case 15:
                TextMesh.text = "Í";
                break;
            case 16:
                TextMesh.text = "Î";
                break;
            case 17:
                TextMesh.text = "Ï";
                break;
            case 18:
                TextMesh.text = "Ð";
                break;
            case 19:
                TextMesh.text = "Ñ";
                break;
            case 20:
                TextMesh.text = "Ò";
                break;
            case 21:
                TextMesh.text = "Ó";
                break;
            case 22:
                TextMesh.text = "Ô";
                break;
            case 23:
                TextMesh.text = "Õ";
                break;
            case 24:
                TextMesh.text = "Ö";
                break;
            case 25:
                TextMesh.text = "×";
                break;
            case 26:
                TextMesh.text = "Ø";
                break;
            case 27:
                TextMesh.text = "Ù";
                break;
            case 28:
                TextMesh.text = "Ú";
                break;
            case 29:
                TextMesh.text = "Û";
                break;
            case 30:
                TextMesh.text = "Ü";
                break;
            case 31:
                TextMesh.text = "Ý";
                break;
            case 32:
                TextMesh.text = "Þ";
                break;
            case 33:
                TextMesh.text = "ß";
                break;

        }
       
       



    }
}
