using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberLvl11 : MonoBehaviour
{

    TextMeshProUGUI TextMesh;
    public GameObject[] cat = new GameObject[9];

    public void Start()
    {


        TextMesh = GetComponent<TextMeshProUGUI>();


    }

    public void addOne1(int a)
    {

        a = Convert.ToInt32(TextMesh.text);

        if (a == 10)
        { 
            for (int e = 0; e < 10; e++)
            {
                cat[e].SetActive(false);


            }
        }
        cat[a].SetActive(true);
        a++;
        if (a == 10)
        {
            a = 0;
            for (int e = 0; e < 10; e++)
            {
                cat[e].SetActive(false);


            }
        }
        TextMesh.text = Convert.ToString(a);
     



    }
}
