using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level23 : MonoBehaviour
{

    public GameObject[] skirt = new GameObject[9];
    public GameObject[] girl = new GameObject[3];
    public GameObject[] buttonSkirt = new GameObject[3];

    public bool permissionButton = true;

    public int GirlID;
    Animator anim;


    public bool girl0, girl1, girl2, levelCheck;
    void Start()
    {

        anim = GetComponent<Animator>();
    }

    public void pressGirl(int girlID)
    {

        
        if (permissionButton)
        {
            if (girl[girlID].activeSelf == false)
            {
                girl[girlID].SetActive(true);
                permissionButton = false;
                GirlID = girlID;
                if (girlID == 0)
                {
                    skirt[0].SetActive(false);
                    skirt[1].SetActive(false);
                    skirt[2].SetActive(false);
                }
                else if (girlID == 1)
                {
                    skirt[3].SetActive(false);
                    skirt[4].SetActive(false);
                    skirt[5].SetActive(false);
                }
                else if (girlID == 2)
                {
                    skirt[6].SetActive(false);
                    skirt[7].SetActive(false);
                    skirt[8].SetActive(false);
                }
            }
             
        }
        else if (girl[girlID].activeSelf == true)
        {

            girl[girlID].SetActive(false);
            permissionButton = true;
            Debug.Log("fwfwfw");

        }


    }
    
        public void pressObject(int Objectid)
        {
            if (GirlID == 0 && permissionButton == false)
            {
                switch (Objectid)
                {

                    case 0:
                        skirt[0].SetActive(true);
                        skirt[1].SetActive(false);
                        skirt[2].SetActive(false);
                        break;
                    case 1:
                        skirt[0].SetActive(false);
                        skirt[1].SetActive(true);
                        skirt[2].SetActive(false);
                        girl0 = true;
                        break;
                    case 2:
                        skirt[0].SetActive(false);
                        skirt[1].SetActive(false);
                        skirt[2].SetActive(true);
                        break;


                }

                girl[GirlID].SetActive(false);
                permissionButton = true;
            } else if (GirlID == 1 && permissionButton == false)
            {
                switch (Objectid)
                {
                    case 0:
                        skirt[3].SetActive(true);
                        skirt[4].SetActive(false);
                        skirt[5].SetActive(false);
                        girl1 = true;
                        break;
                    case 1:
                        skirt[3].SetActive(false);
                        skirt[4].SetActive(true);
                        skirt[5].SetActive(false);
                        break;
                    case 2:
                        skirt[3].SetActive(false);
                        skirt[4].SetActive(false);
                        skirt[5].SetActive(true);
                        break;
                }

                girl[GirlID].SetActive(false);
                permissionButton = true;
            }
            else if (GirlID == 2 && permissionButton == false)
            {
                switch (Objectid)
                {
                    case 0:
                        skirt[6].SetActive(true);
                        skirt[7].SetActive(false);
                        skirt[8].SetActive(false);
                        break;
                    case 1:
                        skirt[6].SetActive(false);
                        skirt[7].SetActive(true);
                        skirt[8].SetActive(false);
                        break;
                    case 2:
                        skirt[6].SetActive(false);
                        skirt[7].SetActive(false);
                        skirt[8].SetActive(true);
                        girl2 = true;
                        break;
                }
                girl[GirlID].SetActive(false);
                permissionButton = true;
            }

            


        }


    public void Checking()
    {

        levelCheck = girl0 == true && girl1 == true && girl2 == true;
        if (levelCheck)
        {


            anim.Play("Correctly");


        }
        else
        {
            anim.Play("Mistake");


        }

    }
    
   
}
