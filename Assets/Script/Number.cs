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

        switch (numberLvl13)    //� � � � � � � � � � � � � � � � � � � � � � � � � � � � � � � � �
        {
            case 1:
                TextMesh.text = "�";
                break;
            case 2:
                TextMesh.text = "�";
                break;
            case 3:
                TextMesh.text = "�";
                 
                break;
            case 4:
                TextMesh.text = "�";
                break;
            case 5:
                TextMesh.text = "�";
                break;
            case 6:
                TextMesh.text = "�";
                break;
            case 7:
                TextMesh.text = "�";
                break;
            case 8:
                TextMesh.text = "�";
                break;
            case 9:
                TextMesh.text = "�";
                break;
            case 10:
                TextMesh.text = "�";
                break;
            case 11:
                TextMesh.text = "�";
                break;
            case 12:
                TextMesh.text = "�";
                break;
            case 13:
                TextMesh.text = "�";
                break;
            case 14:
                TextMesh.text = "�";
                break;
            case 15:
                TextMesh.text = "�";
                break;
            case 16:
                TextMesh.text = "�";
                break;
            case 17:
                TextMesh.text = "�";
                break;
            case 18:
                TextMesh.text = "�";
                break;
            case 19:
                TextMesh.text = "�";
                break;
            case 20:
                TextMesh.text = "�";
                break;
            case 21:
                TextMesh.text = "�";
                break;
            case 22:
                TextMesh.text = "�";
                break;
            case 23:
                TextMesh.text = "�";
                break;
            case 24:
                TextMesh.text = "�";
                break;
            case 25:
                TextMesh.text = "�";
                break;
            case 26:
                TextMesh.text = "�";
                break;
            case 27:
                TextMesh.text = "�";
                break;
            case 28:
                TextMesh.text = "�";
                break;
            case 29:
                TextMesh.text = "�";
                break;
            case 30:
                TextMesh.text = "�";
                break;
            case 31:
                TextMesh.text = "�";
                break;
            case 32:
                TextMesh.text = "�";
                break;
            case 33:
                TextMesh.text = "�";
                break;

        }
       
       



    }
}
