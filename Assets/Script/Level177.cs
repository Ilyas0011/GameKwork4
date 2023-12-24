using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level177 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 startPosition;
    public Vector2 endPosition;

    public float step;
    private float progress;

    public GameObject[] textt = new GameObject[5];
    public GameObject[] input= new GameObject[5];

    public bool startText = false;
    int objectID;
    bool permissionInput = true;
    public bool text0Check, text1Check, text2Check, text3Check, text4Check, levelCheck;

    Animator anim;
     

    void Start()
    {

        anim = GetComponent<Animator>();
    }


    public void inputActivate(int inputid)
    {
         
        if (permissionInput)
        {
            if (input[inputid].activeSelf == false)
            {
                input[inputid].gameObject.SetActive(true);
                permissionInput = false;
            }  
        }
        else if (input[inputid].activeSelf == true)
        {

            input[inputid].gameObject.SetActive(false);
            permissionInput = true;

        }

    }

    public void pressText(int textid)
    {
       
        objectID = textid;
        switch (textid)
        {
            case 0:
                if (input[textid].activeSelf == true && startText == false)
                {
                    startPosition = textt[textid].GetComponent<RectTransform>().anchoredPosition;
                    endPosition = new Vector2(310, 35);
                    startText = true;
                    text0Check = true;
                }
                break;
            case 1:
                if (input[textid].activeSelf == true && startText == false)
                {
                    startPosition = textt[textid].GetComponent<RectTransform>().anchoredPosition;
                    endPosition = new Vector2(146, -80);
                    startText = true;
                    text1Check = true;
                }
                break;
            case 2:
                if (input[textid].activeSelf == true && startText == false)
                {
                    startPosition = textt[textid].GetComponent<RectTransform>().anchoredPosition;
                    endPosition = new Vector2(-82, 136);
                    startText = true;
                    text2Check = true;
                }
                break;
            case 3:
                if (input[textid].activeSelf == true && startText == false)
                {
                    startPosition = textt[textid].GetComponent<RectTransform>().anchoredPosition;
                    endPosition = new Vector2(-225, -3);
                    startText = true;
                    text3Check = true;
                }
                break;
            case 4:
                if (input[textid].activeSelf == true && startText == false)
                {
                    startPosition = textt[textid].GetComponent<RectTransform>().anchoredPosition;
                    endPosition = new Vector2(97, 33);
                    startText = true;
                    text4Check = true;

                }
                break;


        }
        levelCheck = text0Check == true && text1Check == true && text2Check == true && text3Check == true && text4Check == true;
        if (levelCheck)
        {


            anim.Play("Correctly");

        }



    }

     

    IEnumerator offStartText()
    {
        yield return new WaitForSeconds(0.6f);
        progress = 0;
        startText = false;
         
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (startText)
        {
            textt[objectID].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(startPosition, endPosition, progress);
            input[objectID].gameObject.SetActive(false);
            progress += step;
            StartCoroutine(offStartText());
            permissionInput = true;
        }
    }
}
