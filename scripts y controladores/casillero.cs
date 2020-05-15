using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class casillero : MonoBehaviour
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
    public AudioClip clip;
    public GameObject xd;
    public GameObject construir;
    public GameObject construir1;
    public GameObject destruir;
    public GameObject DESTRUIR;
    public GameObject Letras;
    public GameObject Ac;
    public GameObject construir2;
    void Start()
    {

        btn.onClick.AddListener(Sprite);
      

    }

    void Sprite()
    {
        Destroy(xd);
        Destroy(destruir);
        Destroy(DESTRUIR);
        Destroy(Letras);
        Destroy(Ac);
        for (int i = 0; i < 1; i++)
        {
            Instantiate(construir);
        }
        for (int i = 0; i < 1; i++)
        {

            Instantiate(construir1);
        }
        for (int i = 0; i < 1; i++)
        {

            Instantiate(construir2);
        }
    }
}
