using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Playercontroler : MonoBehaviour
{
    public Vector3 gravity;
    public Vector3 JumSpeed;
    bool isGrounded = false;
    Rigidbody rb;
    

    
    void Awake ()
    {
        Physics.gravity= gravity;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.anyKeyDown && isGrounded)
        {
            rb.velocity = JumSpeed;
            isGrounded = false;
        }


    }


    private void OnCollisionEnter(Collision collision)
    {
        isGrounded= true;
    }

}
