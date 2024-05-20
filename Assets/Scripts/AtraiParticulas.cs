using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtraiParticulas : MonoBehaviour
{
    [SerializeField] ParticleSystem particulas;
    [SerializeField] Transform alvo;
    [SerializeField] float delay = 1.5f;
    [SerializeField] float duracao = 2;
    [SerializeField] float velocidade = 2;
    bool atraindo;

    void OnEnable()
    {
        Comeca();
    }

    public void Comeca()
    {
        if (!atraindo)
            StartCoroutine("Atrai");
    }

    IEnumerator Atrai()
    {
        atraindo = true;
        yield return new WaitForSeconds(delay);
        WaitForEndOfFrame endOfFrame = new WaitForEndOfFrame();
        int numeroDeParticulas = particulas.particleCount;
        particulas.Pause();
        ParticleSystem.Particle[] particulasInstanciadas = new ParticleSystem.Particle[numeroDeParticulas];
        particulas.GetParticles(particulasInstanciadas, numeroDeParticulas);
        Vector3[] posicoesIniciais = new Vector3[numeroDeParticulas];
        Transform trPosFinal = alvo;
        for (int i = 0; i < numeroDeParticulas; i++)
        {
            posicoesIniciais[i] = particulasInstanciadas[i].position;
        }
        float tempoDecorrido = 0;
        particulas.Play();
        while (duracao > tempoDecorrido)
        {
            for (int i = 0; i < numeroDeParticulas; i++)
            {
                particulasInstanciadas[i].position = 
                    Vector3.Lerp(particulasInstanciadas[i].position,
                    trPosFinal.position, 
                    Mathf.Pow(tempoDecorrido, velocidade) * Time.deltaTime);
            }
            particulas.SetParticles(particulasInstanciadas);
            yield return endOfFrame;
            tempoDecorrido += Time.deltaTime;
        }
        particulas.Clear();        
        atraindo = false;
    }
}
