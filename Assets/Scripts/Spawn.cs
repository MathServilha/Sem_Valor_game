using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float rate;
    [SerializeField] GameObject[] enemies;
    public int waves = 5;

    void Start()
    {
        InvokeRepeating("SpawnEnemy",rate,rate);
    }

    void SpawnEnemy()
    {
        for(int i = 0; i < waves; i++)
        Instantiate(enemies[(int)Random.Range(0,enemies.Length)],new Vector3(Random.Range(-17.5f,17.5f),15,0),Quaternion.identity); 
    }
}
