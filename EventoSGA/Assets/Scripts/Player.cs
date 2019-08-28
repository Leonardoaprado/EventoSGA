using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Velocidade = 0;

    public float Pulo = 0;

    //public GameObject Tiro;

    public static float x, y;

    //variaveis do tiro teste
    public Transform bulletSpaw;
    public GameObject bulletObject;
    public float FireRate;
    public float NextFire;


 




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
        x = transform.position.x;
        y = transform.position.y;

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

        /* if (Input.GetAxisRaw("Fire1") > 0)
         {
             Instantiate(this.Tiro, new Vector2(Player.x + 0.001f, Player.y - 0.0005f), Quaternion.identity);
         }*/

        if (Input.GetAxisRaw("Fire1") > 0 && Time.time > NextFire)
        {
            animacao.SetTrigger("Fire");
            NextFire = Time.time + FireRate;
            GameObject cloneBullet = Instantiate(bulletObject, bulletSpaw.position, bulletSpaw.rotation);
            if(spritePlayer.flipX)
            {
                cloneBullet.transform.eulerAngles = new Vector3 (0, 0, 180);
            }
        }





    }
}
