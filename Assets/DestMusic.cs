using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestMusic : MonoBehaviour
{
    public GameObject[] objs;
    
    void Start()
    {
        objs = GameObject.FindGameObjectsWithTag("music");


        if (objs.Length > 1)
        {
            Destroy(objs[1].gameObject);
        }

       
    }
 
 
}
