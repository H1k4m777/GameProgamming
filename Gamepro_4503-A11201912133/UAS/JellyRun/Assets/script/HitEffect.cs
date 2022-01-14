using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffect : MonoBehaviour
{
    [SerializeField]
    private GameObject blink,players;
    // Start is called before the first frame update
    void Start()
    {
        blink.SetActive(false);
        players.SetActive(true);
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("spike"))
        {
            Invoke("EnableBlink",0f);
            Invoke("DisableBlink",0.1f);  
        }
        
    }

    void OnTriggerEnter2D(Collider2D colli){
        if(colli.gameObject.CompareTag("enemy"))
        {
            Invoke("EnableBlink",0f);
            Invoke("DisableBlink",0.1f);  
        }
    }

    void EnableBlink(){
        blink.SetActive(true);
        players.SetActive(false);
    }

    void DisableBlink(){
        blink.SetActive(false);
        players.SetActive(true);
    }
}
