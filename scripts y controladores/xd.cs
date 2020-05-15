using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xd : MonoBehaviour
{
    //variables para valores predeterminados para la velocidad y lo movible
    public float speed = 10f;
    private Rigidbody2D xdxd;

    // Start is called before the first frame update
    void Start()
    {
        xdxd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento horizontal 
       

        float hinput1 = Input.GetAxis("Vertical");

        xdxd.AddForce(Vector3.down * speed * hinput1);

    }
}