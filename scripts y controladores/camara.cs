
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class camara : MonoBehaviour
{
    public GameObject follow;
    public Vector2 minCamPos, maxCamPos;

    // Start is called before the cffdvfffirst frame update
    void Start()
    {
       
           
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = follow.transform.position.x;
        float posY = follow.transform.position.y;

        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}
