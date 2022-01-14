using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    void Start()
    {
        
    }

    private static SoundScript instance = null;
    public static SoundScript Instance{
        get {return instance;}
    }

    // Update is called once per frame
    void Awake()
    {
        if (instance != null && instance != this){
            Destroy(this.gameObject);
            return;
        }else{
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
