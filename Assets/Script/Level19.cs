using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level19 : MonoBehaviour
{
    public TextMeshProUGUI[] textMesh = new TextMeshProUGUI[12];
    // Start is called before the first frame update

    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();

    }
    public void Checking()
    {
        var text0 = Convert.ToInt32(textMesh[0].text);
        var text1 = Convert.ToInt32(textMesh[1].text);
        var text2 = Convert.ToInt32(textMesh[2].text);
        var text3 = Convert.ToInt32(textMesh[3].text);
        var text4 = Convert.ToInt32(textMesh[4].text);
        var text5 = Convert.ToInt32(textMesh[5].text);
        var text6 = Convert.ToInt32(textMesh[6].text);
        var text7 = Convert.ToInt32(textMesh[7].text);
        var text8 = Convert.ToInt32(textMesh[8].text);
        var text9 = Convert.ToInt32(textMesh[9].text);
        var text10 = Convert.ToInt32(textMesh[10].text);
        var text11 = Convert.ToInt32(textMesh[11].text);

        bool condition = 5 == text0 && 2 == text1
            && 2 == text2 && 3 == text3
            && 1 == text4 && 6 == text5
            && 1 == text6 && 4 == text7
            && 4 == text8 && 2 == text9
            && 4 == text10 && 3 == text11;


        if (condition)
        {
            anim.Play("Correctly");
        }
        else
        {
            anim.Play("Mistake");
        }


    }
}
