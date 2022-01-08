using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public SpikeScript spikeScript;
    public float JumpForce;

    float score;

    [SerializeField]
    bool isGrounded = false;
    public static bool isAlive = true;
    public static bool khacing;

    Rigidbody2D RB;

    public Text ScoreTxt;
    public GameObject cash;

    // Start is called before the first frame update
    void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;
        isAlive = true;
        cash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isGrounded == true)
            {
                RB.AddForce(Vector2.up * JumpForce);
                isGrounded = false;
            }
        }

        if(isAlive)
        {
            if(khacing == true){
                score += (Time.deltaTime * 4) + 5;
                Debug.Log("kaching");
                khacing = false;
            }else{
                score += Time.deltaTime * 4;
            }
            
            ScoreTxt.text = "SCORE : " + score.ToString("0");
        }

        if(isAlive==false){
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true;
            }
        }

        if(collision.gameObject.CompareTag("spike"))
        {
            HealthScript.health -=1;
                
        }

        
    }

    void EnableCash(){
        cash.SetActive(true);
    }

    void DisableCash(){
        cash.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("spike"))
        {
            // isAlive = false;
            HealthScript.health -=1;
            // spikeScript.destroy();
              
        }

        if(col.gameObject.CompareTag("coin"))
        {
            SoundManager.PlaySound("GetCoin");
            Invoke("EnableCash",0f);
            Invoke("DisableCash",0.3f); 
            
        }
    }


}

