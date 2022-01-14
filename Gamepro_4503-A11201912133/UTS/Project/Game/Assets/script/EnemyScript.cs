using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Vector2 veloc = new Vector2(-4,0);
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D> ().velocity = veloc;
        float range = 2.5f;
        transform.position = new Vector3 (transform.position.x ,transform.position.y - range * Random.value,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D colli){
        if(colli.gameObject.CompareTag("Player"))
        {
            // SoundManager.PlaySound("HealthUp");
            Destroy(this.gameObject);
            if(HealthScript.health != 0){
                HealthScript.health--;
            }
        }
    }

}
