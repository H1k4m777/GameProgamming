using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HigestScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text highscore;
    public float score = PlayerScript.score;

    // Start is called before the first frame update
    void Start()
    {
        if(score > PlayerPrefs.GetFloat("Highscore")){
            PlayerPrefs.SetFloat("Highscore", score);
        }
        highscore.text = "SCORE : " + PlayerPrefs.GetFloat("Highscore").ToString("0");
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
