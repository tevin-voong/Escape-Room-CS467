// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class PauseMenu: MonoBehavior {
    
//     public static bool GameIsPaused = false;

//     public GameObject pasueMenuUI;

//     void Update () {
//         if (Input.GetKeyDown(KeyCode.Escape))
//         {
//             if (GameIsPaused)
//             {
//                 Resume();
//             }
//             else 
//             {
//                 Pause();
//             }
//         }
//     }
//     void Resume ()
//     {
//         pauseMenuUI.SetActive(false);
//         // reverts to normal time to unpause game
//         Time.timeScale = 1f;
//         GameIsPaused = false;
//     }

//     void Pause ()
//     {
//         pauseMenuUI.SetActive(true);
//         // sets time to 0 to "pause" game
//         Time.timeScale = 0f;
//         GameIsPaused = true;
//     }

//     public void LoadMenu()
//     {   
//         // Specify scene named "Menu" to open
//         SceneManager.LoadScene("Menu");
//     }

//     public void QuitGame()
//     {
//         Debug.Log("Quitting game...");
//         Application.Quit();
//     }
// }