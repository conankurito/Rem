using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    private float volume;
    public Text txtVolume;
    public GameObject menu;

    void Start(){
        if(!PlayerPrefs.HasKey("volume"))
            PlayerPrefs.SetFloat("volume",1);
        volume=PlayerPrefs.GetFloat("volume")*10;
        AudioListener.volume=volume/10;
        txtVolume.text=""+volume;
    }

    void Update(){
        Debug.Log("Volume: "+AudioListener.volume);
        if(Input.GetKeyDown(KeyCode.Escape))
            Back();
    }

    public void Back(){
        gameObject.SetActive(false);
        menu.SetActive(true);
        PlayerPrefs.SetFloat("volume",AudioListener.volume);
    }

    public void IncreaseVolume(){
        volume=(volume+1)%11;
        AudioListener.volume=volume/10;     
        txtVolume.text=""+volume;
    }

    public void DecreaseVolume(){
        if(volume==0)
            volume=10;
        else 
            volume=(volume-1)%10;
        AudioListener.volume=volume/10;
        txtVolume.text=""+volume;
    }
}
