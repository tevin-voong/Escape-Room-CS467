using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else 
            {
                Pause();
            }
        }
        
    }
    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        // reverts to normal time to unpause game
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        // sets time to 0 to "pause" game
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

        public void LoadMenu()
    {   
        Debug.Log("Loading Menu...");
        // Specify scene named "Menu" to open
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
