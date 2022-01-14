using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public Vector2 veloc = new Vector2(-4,0);

    void Start()
    {
        GetComponent<Rigidbody2D> ().velocity = veloc;
        float range = 2;
        transform.position = new Vector3 (transform.position.x ,transform.position.y - range * Random.value,transform.position.z);
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D colli){
        if(colli.gameObject.CompareTag("Player"))
        {    
            Destroy(this.gameObject);
            PlayerScript.khacing = true;
        }
    }

}
