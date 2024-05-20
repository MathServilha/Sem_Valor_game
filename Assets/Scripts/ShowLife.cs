using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowLife : MonoBehaviour
{
    Player jogador;
    public Text variableText;

    private void Update()
    {
        Life();
    }

    private void Awake()
    {
        
        jogador = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    public void Life()
    {
        
        variableText.text = "Vida: " + jogador.health;
    }
}

