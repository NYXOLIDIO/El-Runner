using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntaje : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }
   

    // Update is called once per frame
    private void Update()
    {
        puntos += Time.deltaTime;
        textMesh.text = puntos.ToString("0");
    }
}
