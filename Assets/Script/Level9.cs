using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level9 : MonoBehaviour
{
    public int sceneID;

    public GameObject[] letter = new GameObject[33];
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sceneID = SceneManager.GetActiveScene().buildIndex;
    }

    public void checking(int number)
    {
        switch (sceneID)
        {
            case 9:
              
                letter[number].SetActive(true);

                if (letter[0].activeSelf == true
                   && letter[13].activeSelf == true
                    && letter[19].activeSelf == true
                    && letter[25].activeSelf == true
                    && letter[32].activeSelf == true)
                {

                    anim.Play("Correctly");

                }
                break;
            case 22:

                letter[number].SetActive(true);

                if (letter[5].activeSelf == true
                   && letter[11].activeSelf == true
                    && letter[14].activeSelf == true
                    && letter[15].activeSelf == true
                    && letter[22].activeSelf == true)
                {

                    anim.Play("Correctly");

                }
 
                break;
        }

    }

}
