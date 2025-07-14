using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class MoveAircraft : MonoBehaviour
{
    private Rigidbody Rigidbodyrb;
    public float Speed = 5.0f;
    public float RotationSpeed = 1.0f;
    void Start()
    {
        Rigidbodyrb = GetComponent<Rigidbody>();
        Debug.Log(Rigidbodyrb);
    }

    void FixedUpdate()
    {
        float sideForce = Input.GetAxis("Horizontal") * RotationSpeed;
        float forwardForce = Input.GetAxis("Vertical") * Speed;
        Debug.Log(sideForce);
        Debug.Log(forwardForce);
        if (forwardForce == 0)
        {
            //Rigidbodyrb.linearVelocity = new Vector3(0, 0, Rigidbodyrb.linearVelocity.z - 1);
            //Rigidbodyrb.linearVelocity = new Vector3(0, 0, 0);
            if (Rigidbodyrb.linearVelocity.z < 15f || Rigidbodyrb.linearVelocity.z > -15f)
            {
                Rigidbodyrb.linearVelocity = Vector3.zero;
            }
            else
            {
                Rigidbodyrb.AddRelativeForce(0f, 0f, -10f);
            }            
        }
        Rigidbodyrb.AddRelativeForce(0f, 0f, forwardForce);
        //Rigidbodyrb.linearVelocity = new Vector3(0, 0, forwardForce);
        Rigidbodyrb.angularVelocity = new Vector3(0, sideForce * 0.2f, 0);
        //Rigidbodyrb.AddRelativeForce(0f, 0f, forwardForce);
        //Rigidbodyrb.AddRelativeTorque(0f, sideForce, 0f);
    }
}
