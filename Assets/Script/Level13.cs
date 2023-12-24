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
        if ("Á" == textMesh[0].text && "Ð" == textMesh[1].text
            && "Ñ" == textMesh[2].text && "×" == textMesh[3].text
            && "Ã" == textMesh[4].text && "Ç" == textMesh[5].text
            && "Í" == textMesh[6].text && "Ó" == textMesh[7].text)
        {
            anim.Play("Correctly");
        }
        else
        {
            anim.Play("Mistake");
        }


    }
}
