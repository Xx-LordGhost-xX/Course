using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    public float speed = 5;
    public float SwitchEvery = 3;

    private float TimePassed = 0;
    private Vector3 Direction;
    private Rigidbody MyRigidBody;
    void Start()
    {
        MyRigidBody = GetComponent<Rigidbody>();
        Direction = Vector3.up;
            
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        TimePassed += Time.fixedDeltaTime;
        if (TimePassed >= SwitchEvery)
        {
            if (Direction == Vector3.up)
            {
                Direction = Vector3.down;
            }
            else
            {
                Direction = Vector3.up;
            }
            TimePassed = 0;
        }
        float speedPerFixedUpdate = speed * Time.fixedDeltaTime;
        MyRigidBody.MovePosition(transform.position + speedPerFixedUpdate * Direction);
    }
}
