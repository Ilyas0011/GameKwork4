using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level15 : MonoBehaviour
{

    public TextMeshProUGUI[] textMesh = new TextMeshProUGUI[3];
    public GameObject[] apple = new GameObject[6];
    public int leftPlate = 0;
    public int rightPlate = 0;
    public int redPlate = 3;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void addRightPlate()
    {


        switch (redPlate)
        {

            case 3:
                rightPlate++;
                textMesh[2].text = $"1+{rightPlate}={rightPlate + 1}";
                textMesh[0].text = "3-1=2";
                apple[0].SetActive(false);
                apple[6].SetActive(true);
                redPlate--;
                break;
            case 2:
                rightPlate++;
                textMesh[2].text = $"1+{rightPlate}={rightPlate + 1}";
                textMesh[0].text = "3-2=1";
                apple[1].SetActive(false);
                apple[7].SetActive(true);
                redPlate--;
                break;
            case 1:
                rightPlate++;
                textMesh[2].text = $"1+{rightPlate}={rightPlate + 1}";
                textMesh[0].text = "3-3=0";
                apple[2].SetActive(false);
                apple[8].SetActive(true);
                redPlate--;
                break;


        }

    }

    public void addLeftPlate()
    {


        switch (redPlate)
        {
            case 3:
                leftPlate++;
                textMesh[1].text = $"2+{leftPlate}={leftPlate + 2}";
                textMesh[0].text = "3-1=2";
                apple[0].SetActive(false);
                apple[3].SetActive(true);
                redPlate--;
                break;
            case 2:
                leftPlate++;
                textMesh[1].text = $"2+{leftPlate}={leftPlate + 2}";
                textMesh[0].text = "3-2=1";
                apple[1].SetActive(false);
                apple[4].SetActive(true);
                redPlate--;
                break;
            case 1:
                leftPlate++;
                textMesh[1].text = $"2+{leftPlate}={leftPlate + 2}";
                textMesh[0].text = "3-3=0";
                apple[2].SetActive(false);
                apple[5].SetActive(true);
                redPlate--;
                break;


        }

    }



    public void Checking()
    {
        if (textMesh[0].text == "3-3=0"  && textMesh[1].text == "2+1=3" && textMesh[2].text == "1+2=3")
        {
            anim.Play("Correctly");
        }
        else
        {
            anim.Play("Mistake");
        }


    }
}