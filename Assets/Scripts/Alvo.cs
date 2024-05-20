using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alvo : Destrutivel
{
    Player jogador;
    Rigidbody2D rb;
    [SerializeField] GameObject particulas;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        jogador = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    public override void TomaDano()
    {
        base.TomaDano();
        Kill(); 
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Bullet"))
        {
            
            jogador.AcertouTiro();
            
            TomaDano();
            particulas.SetActive(true);
            GerenciadorDeFase.instancia.ContabilizaAlvoDestruido();
            Debug.Log("Destruiu alvo");
        }        
    }
}
