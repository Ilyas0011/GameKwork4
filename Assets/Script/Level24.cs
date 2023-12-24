using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level24 : MonoBehaviour
{

    public GameObject[] passenger = new GameObject[5];
    public GameObject[] windows = new GameObject[5];
    public GameObject[] selected = new GameObject[5];


    public GameObject buttonPassenger;
    public GameObject previewPassenger;

    public int windowsActivID = 5;
    bool activated = false;
    bool accuracy;


    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        windowsActivID = 5;
    }


    public void pressSelected(int WindowID)
    {
        if (activated == false && selected[WindowID].activeSelf == false)
        {
            selected[WindowID].SetActive(true);
            activated = true;
            windowsActivID = WindowID;
        }
        else if (activated == true && selected[WindowID].activeSelf == true)
        {

            selected[WindowID].SetActive(false);
            activated = false;
            windowsActivID = 5;
        }




    }


    public void onPreviev()
    {

        buttonPassenger.SetActive(false);
        previewPassenger.SetActive(true);

    }


    public void offPreviev()
    {

              buttonPassenger.SetActive(true);
            previewPassenger.SetActive(false);

    }

   





    public void pressObject(int objectID)
    {
        if (windowsActivID != 5)
        {
            windows[windowsActivID].GetComponent<Image>().sprite = passenger[objectID].GetComponent<Image>().sprite;
            windows[windowsActivID].GetComponent<ObjectColorId>().ObjectColour = objectID;
            selected[windowsActivID].SetActive(false);
            activated = false;
        }
    }




    public void buttonClickWin()
    {

        var windows0 = windows[0].GetComponent<Image>().sprite;
        var windows1 = windows[1].GetComponent<Image>().sprite;
        var windows2 = windows[2].GetComponent<Image>().sprite;
        var windows3 = windows[3].GetComponent<Image>().sprite;
        var windows4 = windows[4].GetComponent<Image>().sprite;

        var passenger0 = passenger[0].GetComponent<Image>().sprite;
        var passenger1 = passenger[1].GetComponent<Image>().sprite;
        var passenger2 = passenger[2].GetComponent<Image>().sprite;
        var passenger3 = passenger[3].GetComponent<Image>().sprite;
        var passenger4 = passenger[4].GetComponent<Image>().sprite;


        bool accuracy = windows0 == passenger3 && windows1 == passenger2 && windows2 == passenger0 && windows3 == passenger1 && windows4 == passenger4;

        if (accuracy)
        { 
            anim.Play("Correctly");
        }
        else
        {
            anim.Play("Mistake");
        }
    }


   


}
