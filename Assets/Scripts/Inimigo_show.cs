using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo_show : Destrutivel
{   
    Rigidbody2D rb;

    Player jogador;

    public float xSpeed;
    public float ySpeed;
    public float tamanho;
    public float canShoot;
    public float fireRate;
    public float health = 2;
 

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        jogador = GameObject.FindWithTag("Player").GetComponent<Player>();
    } 

    void Update()
    {
        transform.localScale = new Vector3 (tamanho, tamanho, tamanho);
        rb.velocity = new Vector2(xSpeed,ySpeed * -1);
    }    

    private void OnCollisionEnter2D(Collision2D col) 
    {
        Debug.Log(col.gameObject.name);

        if (col.gameObject.tag == "Player"){
            jogador.Damage();
            TomaDano();
        }

        if(col.gameObject.tag == "AntiLag"){
        TomaDano();
        }

        if (col.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Acertou Tiro");
            jogador.AcertouTiro();
            col.gameObject.GetComponent<Bullets>().TomaDano();
            TomaDano();
        }
    }

   
   
}
