using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Velocidade = 0;

    public float Pulo = 0;

    SpriteRenderer spritePlayer;
    Animator animacao;

    // Start is called before the first frame update
    void Start()
    {
        spritePlayer = GetComponent<SpriteRenderer>();
        animacao = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Horizontal") < 0)
        {
            animacao.SetBool("Andar", true);
        }
        else
        {
            animacao.SetBool("Andar", false);
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector3.right * Velocidade);
            spritePlayer.flipX = false;
        }
        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector3.left * Velocidade);
            spritePlayer.flipX = true;

        }





        if (Input.GetAxisRaw("Vertical") < 0)
        {
            animacao.SetBool("Abaixar", true);
        }
        else
        {
            animacao.SetBool("Abaixar", false);
        }

        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(Vector3.down * 0.00005f);
            
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(Vector3.up * Pulo);
            
        }

    }
}
