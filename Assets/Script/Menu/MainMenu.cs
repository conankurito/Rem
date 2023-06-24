using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionMenu;

    void Start(){
        if(SceneManager.sceneCount>1)
            SceneManager.LoadScene(0);  
    }

    public void PlayGame(){
        SceneManager.LoadScene(1);
    }

    public void OpenOption(){
        gameObject.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void ExitGame(){
        Application.Quit();
    }
}
