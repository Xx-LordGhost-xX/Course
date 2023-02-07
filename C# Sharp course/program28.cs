using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLight : MonoBehaviour
{
    public float Speed = 2f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float speedPerUpdate =  Time.deltaTime* Speed;
        transform.position = transform.position + Vector3.right * speedPerUpdate;
    }
}
