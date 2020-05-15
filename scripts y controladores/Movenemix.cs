using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movenemix : MonoBehaviour
{
    public GameObject destruir;
    public float SP = 1f;
    public float MaxSP = 1f;
    public string scene;
    private Rigidbody2D Rb2d;
    public GameObject construir;
    private void Start()
    {
        Rb2d = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        Rb2d.AddForce(Vector2.right * SP);
        if (Rb2d.velocity.x > -0.01 && Rb2d.velocity.x < 0.01)
        {
            SP = -SP;
            Rb2d.velocity = new Vector2(SP, Rb2d.velocity.y);
        }
        Debug.Log(Rb2d.velocity.x);
    }
    
    private void OnTriggerEnter2D(Collider2D colita)

    {
      float DPE = 0.56f;
        if (colita.gameObject.tag == "Player")
        {

            if (transform.position.x + DPE > colita.transform.position.x)
            {
                SceneManager.LoadScene(scene);
            }
        }
        







        if (colita.gameObject.tag == "Player")
        {

            if (transform.position.y + DPE < colita.transform.position.y)
            {
                colita.SendMessage("Enemyxs");
                Destroy(gameObject);
                Destroy(destruir);
                for (int i = 0; i < 1; i++)
                {

                    Instantiate(construir);
                }
            }
        }
        Debug.Log("Player detected");

    }

   
    



}
   
