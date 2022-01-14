using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject spike;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public GameObject coin;

    public float SpeedMultipler;
    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = MinSpeed;
        generateSpike();
    }

    public void GenerateNextSpikeWithGap(){
        float randomwait = Random.Range(1.1f,2.2f);
        Invoke("generateSpike",randomwait);
    }

    public void generateSpike(){
        GameObject SpikeIns = Instantiate(spike,transform.position,transform.rotation);
        SpikeIns.GetComponent<SpikeScript>().spikeGenerator = this;

        // InvokeRepeating ("CreateCoin",1f,3.5f);

    }

    // public void generateCoin(){
    //     gameObject CoinIns = Instantiate(coin,transform.position,transform.rotation);
    //     CoinIns.GetComponent<CoinScript>().spikeGenerator = this;
    // }

    // // void CreateCoin(){
    // //     Instantiate(coin);
    // }
    void Update()
    {
        if(currentSpeed < MaxSpeed)
        {
            currentSpeed += SpeedMultipler;
        }
    }
}
