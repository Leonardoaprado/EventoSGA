using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBarraLateral : MonoBehaviour
{
    public float velocidade = 0.05f;
    public float velDireita = 0.05f;
    public float velEsquerda = 0.05f;
    public GameObject Direita;
    public GameObject Esquerda;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * velocidade);


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Direita)
        {
            velocidade = velDireita * -1;
        }
        if (other.gameObject == Esquerda)
        {
            velocidade = velEsquerda * -1;
        }

    }
}
