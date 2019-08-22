using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBarra : MonoBehaviour
{
    public float velocidade = 0.05f;
    public float velcima = 0.05f;
    public float velbaixo = 0.05f;
    public GameObject cima;
    public GameObject baixo;


    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * velocidade);


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == cima)
        {
            velocidade = velcima * -1;
        }
        if (other.gameObject == baixo)
        {
            velocidade = velbaixo * -1;
        }

    }
}
