using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level21 : MonoBehaviour
{

    public GameObject[] ladybug = new GameObject[9];
    // Start is called before the first frame update

    Animator anim;
    public bool startLadybug = false;
    public Vector2 startPosition;
    public Vector2 endPosition;

    public float step;
    private float progress;
    int objectID;
    public bool ladybugCheck0, ladybugCheck1, ladybugCheck2, ladybugCheck3, ladybugCheck4, ladybugCheck5, ladybugCheck6, ladybugCheck7, ladybugCheck8, levelCheck;
    public Vector2 Iobit;

    
    void Start()
    {
         
        anim = GetComponent<Animator>();
    }

    public void pressObject(int Objectid)
    {

       
        switch (Objectid)
        {
            case 0:
                if (startLadybug == false)
                {
                    startPosition = ladybug[Objectid].transform.position;
                    endPosition = new Vector2(-25f, 15f);
                    ladybugCheck0 = true;
                    objectID = Objectid;
               
                }
                break;
            case 1:
                if (startLadybug == false)
                {
                    startPosition = ladybug[Objectid].transform.position;
                    endPosition = new Vector2(25f, 25f);
                    ladybugCheck1 = true;
                    objectID = Objectid;
                
                }
                break;
            case 2:
                if (startLadybug == false)
                {
                    startPosition = ladybug[Objectid].transform.position;
                    endPosition = new Vector2(-17, 25f);
                    ladybugCheck2 = true;
                    objectID = Objectid;
         
                }
                break;
            case 3:
                if (startLadybug == false)
                {
                    startPosition = ladybug[Objectid].transform.position;
                    endPosition = new Vector2(-21, 25f);
                    ladybugCheck3 = true;
                    objectID = Objectid;
                 
                }
                break;
            case 4:
                if (startLadybug == false)
                {
                    startPosition = ladybug[Objectid].transform.position;
                    endPosition = new Vector2(17, 25f);
                    ladybugCheck4 = true;
                    objectID = Objectid;
         
                }
                break;
            case 5:
                if (startLadybug == false)
                {
                    startPosition = ladybug[Objectid].transform.position;
                    endPosition = new Vector2(25f, 17);
                    ladybugCheck5 = true;
                    objectID = Objectid;
               
                }
                break;
            case 6:
                if (startLadybug == false)
                {
                    startPosition = ladybug[Objectid].transform.position;
                    endPosition = new Vector2(-19, 25f);
                    ladybugCheck6 = true;
                    objectID = Objectid;
            
                }
                break;
            case 7:
                if (startLadybug == false)
                {
                    startPosition = ladybug[Objectid].transform.position;
                    endPosition = new Vector2(25f, 17);
                    ladybugCheck7 = true;
                    objectID = Objectid;
           
                }
                break;
            case 8:
                if (startLadybug == false)
                {
                    startPosition = ladybug[Objectid].transform.position;
                    endPosition = new Vector2(-21, -25f);
                    ladybugCheck8 = true;
                    objectID = Objectid;
                   
                }

                break;
 


        }
       
    }

    public void Checking()
    {

        levelCheck = ladybugCheck0 == false && ladybugCheck1 == true && ladybugCheck2 == false && ladybugCheck3 == false && ladybugCheck4 == true && ladybugCheck5 == false && ladybugCheck6 == false && ladybugCheck7 == false && ladybugCheck8 == true;
        if (levelCheck)
        {


            anim.Play("Correctly");
        }else
        {



            anim.Play("Mistake");
        }    


    }

 

    void FixedUpdate()
    {
         
            ladybug[objectID].GetComponent<RectTransform>().anchoredPosition += endPosition;
             
        
       
    }
}
