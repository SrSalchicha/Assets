using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TKSL1 : MonoBehaviour


{
    private CONTROLADORMOVE hero;
    // Start is called before the first frame update
    void Start()
    {
        hero = GetComponentInParent<CONTROLADORMOVE>();
    }

    void OnCollisionEnter2D(Collision2D cola)
    {
        if (cola.gameObject.tag == "piso")
        {
            hero.TKSL = true;
        }
    }
    void OnCollisionExit2D(Collision2D cola)
    {
        if (cola.gameObject.tag == "piso")
        {
            hero.TKSL = false;
        }
    }
}

