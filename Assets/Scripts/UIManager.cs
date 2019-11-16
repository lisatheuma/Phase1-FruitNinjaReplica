using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    
    public static bool GamePaused = false;
    public static bool GameOver = false;
    public GameObject pauseMenu;
    public GameObject gameOver;


    void OnMouseExit() {
        GoTogame();
    }
    public void GoTogame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        Debug.Log("Opening AR...");
    }

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePaused == false)
            {
                Pause();
            }else
            {
                Resume();
            }
            
        } 
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void OnPlayerDeath()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0f;
        GameOver = true;
    }

}
