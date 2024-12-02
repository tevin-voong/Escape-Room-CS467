using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Loads Yellow Room when clicking Play Game
    public void PlayGame ()
    {
        SceneManager.LoadScene("Yellow Room");
    }

    // Closes application
    public void QuitGame ()
    {   
        // Debug log to show function is firing
        Debug.Log("QUIT");
        Application.Quit();
    }
}