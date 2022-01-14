using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public SpikeGenerator spikeGenerator;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * spikeGenerator.currentSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nextline"))
        {
            spikeGenerator.GenerateNextSpikeWithGap();
        }

        

        if(collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }   
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player"))
        {
            SoundManager.PlaySound("hit");
            Destroy(this.gameObject);
            Debug.Log("hit");
        }
    }

    public void destroy(){
        Destroy(this.gameObject);
    }
}
