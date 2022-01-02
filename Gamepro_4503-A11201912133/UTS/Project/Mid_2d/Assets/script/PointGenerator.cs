using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGenerator : MonoBehaviour
{
    public GameObject coin;
    public GameObject lifes;
    public GameObject enemy;

    void Start()
    {
        InvokeRepeating ("CreateCoin",2f,6.5f);
        InvokeRepeating ("CreateLifes",2f,6f);
        InvokeRepeating("CreateEnemy",2f,6.5f);
    }

    void CreateCoin(){
        Instantiate(coin);
    }

    void CreateLifes(){
        Instantiate(lifes);
    }

    void CreateEnemy(){
        Instantiate(enemy);
    }

    void Update()
    {
        
    }
}
