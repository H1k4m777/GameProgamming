using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIScript : MonoBehaviour
{

    public void OnClick(string NameScene){
        SceneManager.LoadScene(NameScene);
    }

    public void OnExit(){
        Application.Quit();
    }

}
