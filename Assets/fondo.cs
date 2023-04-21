using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fondo : MonoBehaviour
{
    public float scrollFactor = -1;
        public Vector3 gameVelocity;

    Rigidbody rb;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.velocity = gameVelocity * scrollFactor;
    }

    void OnTriggerExit(Collider gameArea)
    {
        transform.position += Vector3.right * (gameArea.bounds.size.x + GetComponent<BoxCollider>().size.x);
    }
    
    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Update()
    {
        
    }
}
