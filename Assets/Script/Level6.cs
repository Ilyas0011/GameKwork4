using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Level6 : MonoBehaviour
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
        if (3 == Convert.ToInt32(textMesh[0].text) && 3 == Convert.ToInt32(textMesh[1].text)
            && 6 == Convert.ToInt32(textMesh[2].text) && 4 == Convert.ToInt32(textMesh[3].text)
            && 1 == Convert.ToInt32(textMesh[4].text) && 5 == Convert.ToInt32(textMesh[5].text)
            && 3 == Convert.ToInt32(textMesh[6].text) && 2 == Convert.ToInt32(textMesh[7].text)
            && 5 == Convert.ToInt32(textMesh[8].text) && 3 == Convert.ToInt32(textMesh[9].text)
            && 4 == Convert.ToInt32(textMesh[10].text) && 7 == Convert.ToInt32(textMesh[11].text))
        {
            anim.Play("Correctly");
        }
        else
        {
            anim.Play("Mistake");
        }


    }
}
