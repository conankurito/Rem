using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private PlayerInput inputManager;
    public GameObject optionMenu;

    void Start(){
        inputManager=GameObject.Find("Player").GetComponent<PlayerInput>();
    }

    void Update(){
        if(inputManager.onFoot.Escape.triggered)
            ResumeGame();
    }

    public void ResumeGame(){
        Time.timeScale=1;
        Cursor.visible=false;
        gameObject.SetActive(false);
    }

    public void OpenOption(){
        gameObject.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void ExitToMenu(){
        Time.timeScale=1;
        SceneManager.LoadScene(0);
    }
}
