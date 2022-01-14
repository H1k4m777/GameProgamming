using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPause : MonoBehaviour
{
    public bool play,pause;

    // Start is called before the first frame update
    void Start()
    {
        playPause();
    }

    public void playPause(){
        if(pause == true){
            SoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }else if(play == true){
            SoundScript.Instance.gameObject.GetComponent<AudioSource>().UnPause();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
