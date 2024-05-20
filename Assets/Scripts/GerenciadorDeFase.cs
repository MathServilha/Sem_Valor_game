using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDeFase : MonoBehaviour
{
    public static GerenciadorDeFase instancia;
    private int alvosDestruidos;
    private int totalDeAlvos;
    private int playersDestruidos;
    private int totalDePlayers = 1;
    [SerializeField] GameObject winMenu;
    [SerializeField] GameObject defeatMenu;
    private int jogador;

    private void Awake()
    {
        if (instancia == null)
        {
            //primeiro que xiste
            instancia = this;
        } else
        {
            Destroy(instancia.gameObject);
            //next guy
            instancia = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        totalDeAlvos = GameObject.FindGameObjectsWithTag("Alvo").Length;
        jogador = GameObject.FindGameObjectsWithTag("Player").Length;
        Debug.Log(totalDeAlvos);
    }



    public void ContabilizaAlvoDestruido()
    {
        alvosDestruidos++;
        Debug.Log("Contabilizou");
        if (alvosDestruidos >= totalDeAlvos)
        { 
            Debug.Log("Verificou");
            PassaDeFase();
        }
    }

    public void ContabilizaPlayerDestruido()
    {
        playersDestruidos++;
        Debug.Log("Contabilizou player");
        if (playersDestruidos >= 1)
        {
            Debug.Log("Verificou plyer");
            PerdeFase();
            playersDestruidos = 0;
        }
    }

    public void PassaDeFase()
    {


        winMenu.SetActive(true);
       

    }

    public void PerdeFase()
    {


        defeatMenu.SetActive(true);


    }


}
