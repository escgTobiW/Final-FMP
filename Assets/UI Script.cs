using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{

    public GameObject Main;
    public GameObject Options;

    public GameObject Audio;
    public GameObject Controls;



    void Start()
    {
     
        Options.SetActive(false);
        Audio.SetActive(false);
        Controls.SetActive(false);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    
    void Update()
    {
     

    }



    public void Play()
    {
        Object.FindFirstObjectByType<AudioManagerScript>().Play("press");
        SceneManager.LoadScene("START");
    }

    public void OptionMenu()
    {
        Object.FindFirstObjectByType<AudioManagerScript>().Play("press");
        Options.SetActive(true);
        Audio.SetActive(false);
        Controls.SetActive(false);
        Main.SetActive(false);
    }

    public void AudioMenu()
    {
        Object.FindFirstObjectByType<AudioManagerScript>().Play("press");
        Audio.SetActive(true);
        Options.SetActive(false);
    }

    public void ControlsMenu()
    {
        Object.FindFirstObjectByType<AudioManagerScript>().Play("press");
        Controls.SetActive(true);
        Options.SetActive(false);
    }
    public void MainMenu()
    {
        Object.FindFirstObjectByType<AudioManagerScript>().Play("press");
        Options.SetActive(false);
        Main.SetActive(true);
    }

    public void Quit()
    {
        Object.FindFirstObjectByType<AudioManagerScript>().Play("press");
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }


}






