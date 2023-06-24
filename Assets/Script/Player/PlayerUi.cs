using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUi : MonoBehaviour
{
    private PlayerInput inputManager;
    [SerializeField]
    private TextMeshProUGUI promptText;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        inputManager=GetComponent<PlayerInput>();
    }

    void Update(){
        if(inputManager.onFoot.Escape.triggered){
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible=true;
            pauseMenu.SetActive(true);
            Time.timeScale=0;
        }
    }

    // Update is called once per frame
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }
}
