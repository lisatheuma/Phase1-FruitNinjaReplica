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
    public GameObject attention;

    //public TrailActivebool playerLine;
    //public ParticleEmitter playerLine = true;
    TrailRenderer trail;

    void OnMouseExit() {
        GoTogame();
    }
    public void GoTogame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
        Debug.Log("Opening AR...");
    }

    void Update() 
    {
        trail = GetComponent<TrailRenderer>();
        trail.time = 1f;
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
        //playerLine.emitting = false;
        Time.timeScale = 0f;
        GamePaused = true;

        
    }
    
    public void Quit()
    {
        attention.SetActive(true);
        //playerLine.emitting = true;
        Time.timeScale = 0f;
        GamePaused = true;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        //playerLine.emitting = true;
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
