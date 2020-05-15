using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atake : MonoBehaviour
{
    public float VEF = 1f;
    public float LIF = 15f;

    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(VEF, 0, 0);
    }



    private void Update()
    {
        if (transform.position.x > 15f)
        {
            Destroy(gameObject);
            print("fuchi disparo");
        }// puto gei
    }//hola

   
}
