using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atake2 : MonoBehaviour
{
    public float VEF2 = -1f;
    public float LIF2 = -15f;

    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(VEF2, 0, 0);
    }



    private void Update()
    {
        if (transform.position.x > LIF2)
        {
            Destroy(gameObject);
            print("fuchi disparo");
        }
    }

}
