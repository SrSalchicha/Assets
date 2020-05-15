using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letra2 : MonoBehaviour
{
    GameObject cosa;
    GameObject xd;
    public GameObject signo;
    public GameObject flecha;
    public void Start()
    {

        cosa = GameObject.Find("Text");
        Destroy(cosa, (float)4);
        xd = GameObject.Find("stunc");
        Destroy(xd, (float)4);
        Destroy(signo, (float)4);
        Destroy(flecha, (float)4);
    }
}
