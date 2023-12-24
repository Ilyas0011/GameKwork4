using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Level25 : MonoBehaviour
{

    public GameObject[] buttonbeads = new GameObject[3];
    public GameObject[] beads = new GameObject[3];

    public bool permissionButton = true;
   public bool bead0, bead1, bead2, levelCheck;
    public int ButtonID;
    int mistakes = 0;
    public TextMeshProUGUI textMesh;



    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        textMesh.text = "Ошибки: 0";
        anim = GetComponent<Animator>();
    }
    public void buttonActivate(int buttonid)
    {
      
        ButtonID = buttonid;
        if (permissionButton)
        {
            if (buttonbeads[buttonid].activeSelf == false)
            {
                buttonbeads[buttonid].gameObject.SetActive(true);
                permissionButton = false;
            
            }
        }
        else if (buttonbeads[buttonid].activeSelf == true)
        {

            buttonbeads[buttonid].gameObject.SetActive(false);
            permissionButton = true;

        }

    }


    public void pressObject(int Objectid)
    {


        switch (Objectid)
        {
            case 0:
                if (bead0 == false && permissionButton == false && ButtonID == 0)
                {
                    
                        permissionButton = true;
                        beads[0].GetComponent<Animator>().Play("bead");
                        bead0 = true;
                        buttonbeads[ButtonID].gameObject.SetActive(false);
                        Debug.Log("1");
                     
                }
                else if (permissionButton == false)
                {

                    mistakes++;
                    textMesh.text = $"Ошибки: {mistakes}";
                    Debug.Log("4");
                }



                break;
            case 1:
                if (bead1 == false && permissionButton == false && ButtonID == 1)
                {
                     
                        beads[1].GetComponent<Animator>().Play("bead2");
                        bead1 = true;
                        permissionButton = true;
                        buttonbeads[ButtonID].gameObject.SetActive(false);
                        Debug.Log("2");
                     
                      
                }
                if (permissionButton == false)
                {

                    mistakes++;
                    textMesh.text = $"Ошибки: {mistakes}";
                    Debug.Log("4");
                }
                break;
            case 2:
                if (bead2 == false && permissionButton == false && ButtonID == 2)
                {
                     
                        beads[2].GetComponent<Animator>().Play("bead3");
                        bead2 = true;
                        permissionButton = true;
                        buttonbeads[ButtonID].gameObject.SetActive(false);
                    Debug.Log("3");
                }
                else if (permissionButton == false)
                {

                    mistakes++;
                    textMesh.text = $"Ошибки: {mistakes}";
                    Debug.Log("4");
                }
                break;



        }
                levelCheck = bead0 == true && bead1 == true && bead2 == true; 
                if (levelCheck)
                {
                    anim.Play("Correctly");
                }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
