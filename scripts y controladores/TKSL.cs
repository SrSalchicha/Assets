using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cola : MonoBehaviour


{
    private CONTROLADORMOVE hero;
    
    void Start()
    {
        hero = GetComponentInParent<CONTROLADORMOVE>();
    }

    void OnCollisionEnter2D(Collision2D cola)
    {
        if (cola.gameObject.tag == "piso") //puto conejo xd
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
