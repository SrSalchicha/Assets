using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letra : MonoBehaviour
{
    GameObject cosa;


    public void Start()
    {
       cosa = GameObject.Find("letra");
        Destroy(cosa, (float)2);
    }
}

