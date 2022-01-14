using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip HealthUp,GetCoin,hit;
    static AudioSource AudioSrc;
    // Start is called before the first frame update
    void Start()
    {
        HealthUp = Resources.Load<AudioClip> ("HealthUp");
        GetCoin = Resources.Load<AudioClip> ("GetCoin");
        hit = Resources.Load<AudioClip> ("hit");


        AudioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public static void PlaySound(string clip){
        switch(clip){
        case "HealthUp" :
            AudioSrc.PlayOneShot(HealthUp);
            break;
        case "GetCoin" :
            AudioSrc.PlayOneShot(GetCoin);
            break;
        case "hit" :
            AudioSrc.PlayOneShot(hit);
            break;
        }
    }
    
}
