using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mounstro : MonoBehaviour
{
 
    public float SP = 1f;
    public float MaxSP = 1f;
    public string scene;
    private Rigidbody2D Rb2d2;
    

    void Start()
    {
        Rb2d2 = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Rb2d2.AddForce(Vector2.right * SP);
        if (Rb2d2.velocity.x > -0.01 && Rb2d2.velocity.x < 0.01)
        {
            SP = -SP;
            Rb2d2.velocity = new Vector2(SP, Rb2d2.velocity.y);
        }
        Debug.Log(Rb2d2.velocity.x);
    }

    private void OnTriggerEnter2D (Collider2D colota)
    {

        float DPE = 0.56f;
        if (colota.gameObject.tag == "Player")
        {

            if (transform.position.x + DPE > colota.transform.position.x)
            {
                SceneManager.LoadScene(scene);
            }
        }

        if (colota.gameObject.tag == "ladrilloxd")
        {

            Destroy(gameObject);

        }


        Debug.Log("ladrilloxd detected");
    }
}
