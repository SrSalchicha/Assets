using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vidas : MonoBehaviour
{
    int vida = 5; //numero de vidas 
    public string escena;
    public GameObject v1;
    public GameObject v2;
    public GameObject v3;
    public GameObject v4;
    public GameObject v5;
    public GameObject v6;
    public GameObject v7;
    public GameObject v8;
    public GameObject v9;
    public GameObject v10;
   static int hp = 10;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D colota)

    {
        float DPE = 0.56f;
        if (colota.gameObject.tag == "Player")
        {       //baja de vida 
            if (transform.position.x + DPE < colota.transform.position.x) 
            {

                vida--;
                
            }


            
            


        }
       if(vida == 9)
        {
            Destroy(v10);
        }
       if(vida == 8)
        {
            Destroy(v9);
        }
       if(vida == 7)
        {
            Destroy(v8);
        }
       if(vida == 6)
        {
            Destroy(v7);
        }
       if(vida == 5)
        {
            Destroy(v6);
        }
        if(vida == 4)
        {
            Destroy(v5);
        }
        if(vida == 3)
        {
            Destroy(v4);
        }
        if(vida == 2)
        {
            Destroy(v3);
        }
        if (vida == 1)
        {
            Destroy(v2);
        }
        if (vida == 0 )
        {

                 //cambio de escena 
                SceneManager.LoadScene(escena);
            
        }
        
    }
}

