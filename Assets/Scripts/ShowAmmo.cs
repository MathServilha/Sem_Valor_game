using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAmmo : MonoBehaviour
{
    // Start is called before the first frame update
    Player jogador;
    public Text variableText;

    private void Update()
    {
        Ammo();
    }

    private void Awake()
    {

        jogador = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    public void Ammo()
    {

        variableText.text = "Munição: " + jogador.balas;
    }
}
