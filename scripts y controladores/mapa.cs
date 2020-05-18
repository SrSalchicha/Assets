using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class mapa : MonoBehaviour
{

    public GameObject construir;
   
    // Start is called before the first frame update
    public void colota()
    {
        

        if (Input.GetKeyDown(KeyCode.F3))
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(construir);

            }
            print("ya quedo");

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {

            Destroy(construir);

        }
       

    }


}
