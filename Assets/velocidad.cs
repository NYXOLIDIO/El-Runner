using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class velocidad : MonoBehaviour
{
    public float velocidadInicial = 5.0f;
    public float aceleracion = 0.5f;
    public float velocidadMaxima = 10.0f;

    private float velocidadActual;
    private Vector3 posicionInicial;
    public static float velocidadGlobal = 0.0f;

    private void Start()
    {
        posicionInicial = transform.position;
        velocidadActual = velocidadInicial;

        if (velocidadGlobal == 0.0f)
        {
            velocidadActual = velocidadInicial;
            velocidadGlobal = velocidadActual;
        }
        else
        {
           
            velocidadActual = velocidadGlobal;
        }
    }

    private void Update()
    {
        
        velocidadActual += aceleracion * Time.deltaTime;
        velocidadActual = Mathf.Min(velocidadActual, velocidadMaxima);

        
        transform.Translate(Vector3.left * velocidadActual * Time.deltaTime);


        if (velocidadActual > velocidadGlobal)
        {
            velocidadGlobal = velocidadActual;
        }

        if (transform.position.x < -20.0f)
        {
            transform.position = posicionInicial;
        }
    }


    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }





}