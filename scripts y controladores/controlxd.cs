using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlxd : MonoBehaviour
{
    GameObject cosa;


    public void Start()
    {

        cosa = GameObject.Find("punto de control");
        Destroy(cosa, (float).5);
    }
}
