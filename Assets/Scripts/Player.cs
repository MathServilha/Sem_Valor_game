using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Destrutivel
{
    GameObject A;
    public GameObject bullet;
    Rigidbody2D rb;
    

    float delay = 5;

    public float speed;
    public int health = 3;
    bool podeAtirar = true;
    public int balas = 0;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        A = transform.Find("A").gameObject;
        
    }
    void Update()
    {
        AtiraOuMorre();
        //Debug.Log(delay);
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed,0));
        rb.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed));

        if(Input.GetKey(KeyCode.Space) && delay > 3)
        {
            Shoot();
        }

        if(delay > 5 && balas == 0)
        {
            TomaDano();
            GerenciadorDeFase.instancia.ContabilizaPlayerDestruido();
        }

        delay += Time.deltaTime;
    }
 
    public void Damage()
    {
        health --;
        
        if (health == 0){
            TomaDano();
            GerenciadorDeFase.instancia.ContabilizaPlayerDestruido();
        }
        
    }
    void Shoot(){
        if(podeAtirar == true){
            delay = 0;
            Instantiate(bullet,A.transform.position,Quaternion.identity);
            balas--;
        }
    }
    public void AcertouTiro()
    {
        Debug.Log("Acertou Tiro");
        balas = balas + 1;
    }
    

    public void AtiraOuMorre(){
        if(balas > 0)
        {
            podeAtirar = true;
        }else 
            podeAtirar = false;
    }
}