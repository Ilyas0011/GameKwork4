using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level11 : MonoBehaviour
{
    public TextMeshProUGUI[] textMesh = new TextMeshProUGUI[4];
    // Start is called before the first frame update

    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();

    }
    public void Checking()
    {
        if (7 == Convert.ToInt32(textMesh[0].text) && 3 == Convert.ToInt32(textMesh[1].text)
            && 6 == Convert.ToInt32(textMesh[2].text) && 5 == Convert.ToInt32(textMesh[3].text))
        {
            anim.Play("Correctly");
        }
        else
        {
            anim.Play("Mistake");
        }


    }
}
