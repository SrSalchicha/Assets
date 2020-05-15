using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class botonZ : MonoBehaviour
{
    public Sprite source
    {
        get
        {
            return GetComponent<Sprite>();
        }
    }
    public Button btn
    {
        get
        {
            return GetComponent<Button>();
        }
    }
  
    public GameObject construir;
    public GameObject construir1;

    void Start()
    {

        btn.onClick.AddListener(Sprite);


    }

    void Sprite()
    {
       
        for (int i = 0; i < 1; i++)
        {
            Instantiate(construir);
        }
        for (int i = 0; i < 1; i++)
        {
            Instantiate(construir1);
        }

    }
}
