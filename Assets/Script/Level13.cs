using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level13 : MonoBehaviour
{
    public TextMeshProUGUI[] textMesh = new TextMeshProUGUI[8];
    // Start is called before the first frame update

    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();

    }
    public void Checking()
    {
        if ("�" == textMesh[0].text && "�" == textMesh[1].text
            && "�" == textMesh[2].text && "�" == textMesh[3].text
            && "�" == textMesh[4].text && "�" == textMesh[5].text
            && "�" == textMesh[6].text && "�" == textMesh[7].text)
        {
            anim.Play("Correctly");
        }
        else
        {
            anim.Play("Mistake");
        }


    }
}
