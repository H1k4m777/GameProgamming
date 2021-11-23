using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject h1,h2,h3;
    public static int health;
    void Start()
    {
        health = 3;
        h1.gameObject.SetActive(true);
        h2.gameObject.SetActive(true);
        h3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(health>3){
            health = 3;
        }

        switch(health){
        case 3:
            h1.gameObject.SetActive(true);
            h2.gameObject.SetActive(true);
            h3.gameObject.SetActive(true);
            break;

        case 2:
            h1.gameObject.SetActive(true);
            h2.gameObject.SetActive(true);
            h3.gameObject.SetActive(false);
            break;

        case 1:
            h1.gameObject.SetActive(true);
            h2.gameObject.SetActive(false);
            h3.gameObject.SetActive(false);
            break;

        case 0:
            h1.gameObject.SetActive(false);
            h2.gameObject.SetActive(false);
            h3.gameObject.SetActive(false);
            PlayerScript.isAlive = false;
            // PlayerScript.gameOver();
            break;
        }
    }
}
