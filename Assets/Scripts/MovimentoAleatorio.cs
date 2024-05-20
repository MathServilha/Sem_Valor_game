using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoAleatorio : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float velDeMovimento = 1;
    [SerializeField] float movimentoAleatorioHorizontal;
    [SerializeField] float delay;
    [SerializeField] bool toque = false;
    [SerializeField] bool seMexe = false;
    [SerializeField] double maxRange = 0.5;
    [SerializeField] LayerMask Layer;
    [SerializeField] Rigidbody2D rb;
    Vector2 velFinal;
    Vector2 velAtual;

    //float inputVertical;

    // Start is called before the first frame update
    void Start()
    {
        GeraDirecao();
    }

    // Update is called once per frame
    void Update()
    {

        if(seMexe) { 
            MovimentoNPC();
            ChecaHorizontal();
            delay++;
        }

    }

    void MovimentoNPC()
    {


        if (movimentoAleatorioHorizontal == 0)
        {
            movimentoAleatorioHorizontal++;
        }



        velAtual.x = velDeMovimento * movimentoAleatorioHorizontal;


        velFinal.x = velAtual.x;
        rb.velocity = velFinal;


    }

    void ChecaHorizontal()
    {

        if (delay >= 40 && rb.IsTouchingLayers(Layer))
        {
            movimentoAleatorioHorizontal *= -1;
            delay = 0;
        }

    }

    void GeraDirecao()
    {
        movimentoAleatorioHorizontal = (Random.Range(-1, 1));
      }
}
