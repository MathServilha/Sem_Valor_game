using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : Destrutivel
{
    Player jogador;
    Rigidbody2D rb;
    int direction = 1;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.layer = 14;
        jogador = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    public void ChangeDirection()
    {
        direction *= -1;
    }

    void Update()
    {
        rb.velocity = new Vector2(0, direction * 8);

    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("AlvoKeeper"))
        {
            TomaDano();
        }

        if (col.gameObject.CompareTag("EnemyKeeper"))
        {
            TomaDano();
        }

        if (col.gameObject.CompareTag("Boss"))
        {
            TomaDano();
            jogador.TomaDano();
            GerenciadorDeFase.instancia.ContabilizaPlayerDestruido();
            return;
        }
       
    }
    
}



