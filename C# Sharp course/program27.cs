using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    private Rigidbody MyRigidBody;
    public float JumpPower = 30;
    void Start()
    {
        MyRigidBody = GetComponent<Rigidbody>();
        MyRigidBody.velocity = Vector3.up * JumpPower;
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
      
    }
}
