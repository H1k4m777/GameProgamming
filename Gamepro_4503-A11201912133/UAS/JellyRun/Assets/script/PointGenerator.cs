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
        InvokeRepeating ("CreateCoin",6f,7f);
        InvokeRepeating ("CreateLifes",10f,10f);
        InvokeRepeating("CreateEnemy",4f,4f);
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
