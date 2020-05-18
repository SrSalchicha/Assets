using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONTROLADORMOVE : MonoBehaviour
{
    //variables para valores predeterminados para la velocidad y lo movible

    private Rigidbody2D xdxd;
    public float maxspeed = 5f;
    public float speed = 2f;
    public bool TKSL;
    public float FDsalto = 6.5f;
    public GameObject construir;
    public GameObject destruir;
    private bool salto;
    private Rigidbody2D rb2d;
    private Animator anima;
    private bool movement = true;
    public GameObject construir2;
    public GameObject construir3;

    // Start is called before the first frame update
    void Start()
    {
        xdxd = GetComponent<Rigidbody2D>();
        rb2d = GetComponent<Rigidbody2D>();
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.F3))
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(construir);

            }
            print("ya quedo");
            Destroy(destruir);



            for (int i = 0; i < 1; i++)
            {
                Instantiate(construir2);

            }

            for (int i = 0; i < 1; i++)
            {
                Instantiate(construir3);

            }

        }


        anima.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));
        anima.SetBool("TKSL", TKSL);

        if (Input.GetKeyDown(KeyCode.Space) && TKSL)
        {
            salto = true;
        }
        //movimiento horizontal 
        float hinput = Input.GetAxis("Horizontal");
        if (!movement) hinput = 0;

        xdxd.AddForce(Vector2.right * speed*hinput);

        if (hinput > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (hinput < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        // disparo xd
       

    }

    void FixedUpdate()
    {

        if (salto)
        {
            rb2d.AddForce(Vector2.up * FDsalto, ForceMode2D.Impulse);
            salto = false;
        }
        Debug.Log(rb2d.velocity.x);
    }

    void OnBecameInvisible()
    {
        transform.position = new Vector3(-1, 0, 0);
    }

    public void Enemyxs()
    {
        salto = true;
    }

    public void EnemixCHR(float EnemixPosx)
    {
        salto = true;

        float side = Mathf.Sign(EnemixPosx - transform.position.x);
        rb2d.AddForce(Vector2.left * side* FDsalto, ForceMode2D.Impulse);

        movement = false;
        Invoke("Enablemov", 0.7f);
    }
    void Enablemov()
    {
        movement = true;
    }
}