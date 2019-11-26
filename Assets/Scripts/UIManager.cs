using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    
    public static bool GamePaused = false;
    //public static bool GameOver = false;
    public GameObject pauseMenu;
    public GameObject gameOver;
    public GameObject attention;
    public Text score;
    public Text finalHighscoreText;
    public Text finalScoreText;

    [SerializeField] TrailRenderer trail;


    void OnMouseExit() {
        GoTogame();
    }

    public void GoTogame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
        Debug.Log("Opening AR...");
        Score.scoreamount = 0;
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
        trail.emitting = false;
        GamePaused = true;
    }

    public void No()
    {
        attention.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true; 
    }
    
    public void Quit()
    {
        attention.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
    public void Resume()
    {
        attention.SetActive(false);
        pauseMenu.SetActive(false);
        trail.emitting = true;
        Time.timeScale = 1f;
        GamePaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void DoGameOver()
    {
        trail.emitting = false;
        GamePaused = true;
        Time.timeScale = 0;
        gameOver.SetActive(true);
        GameObject.Find("Score").GetComponent<Text>();
        finalScoreText.text = "Total Score\n" + Score.scoreamount;
        finalHighscoreText.text = "Highscore\n" + Score.totalhighscore;
    }

}
