using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    
    public static bool GamePaused = false;
    public static bool GameOver = false;
    //public bool isDead = false;
    public GameObject pauseMenu;
    public GameObject gameOver;
    public GameObject attention;
    public Text scoreText;
    public Text highscoreText;
    public Text finalHighScoreText;
    public Text finalScoreText;
    SpriteRenderer _stageCounterFill;
    public Image stageCounterFill;
    public Text stageCount;
    public static int stageamount = 0;
    private int _cutSushi = 0;
    private int _score = 0;
    //public static int scoreamount;
    public static int totalhighscore;
    public int startingHearts;
    private int heartCount;

    [SerializeField]
    public Text _hearts;
    [SerializeField] TrailRenderer trail;
    

    void Start()
    {
        heartCount = startingHearts;
        Time.timeScale = 1f;
        // highscoreText.text = totalhighscore.ToString(); 
        //highscoreText.text = "" +totalhighscore;
    }

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
        _hearts.text = "x" +heartCount;
        AddHighscore();
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

    public void AddScore()
    {
        _cutSushi++;
        _score++;

        if (_cutSushi >= stageamount)
        {
            _cutSushi -= stageamount;
            stageamount++;
        }

        stageCounterFill.fillAmount = (float) _cutSushi / (float) stageamount;
        stageCount.text = stageamount.ToString();
        scoreText.text = _score.ToString();
        //scoreText.text =  scoreamount.ToString();
    }

    public void AddHighscore()
    {

        highscoreText.text = totalhighscore.ToString(); 
        //

        if(_score >= totalhighscore)
        {
            totalhighscore = _score;
            
        }else
        {
            highscoreText.text = "" +totalhighscore;
        }
    }

    public void DoGameOver()
    {
        trail.emitting = false;
        GamePaused = true;
        Time.timeScale = 0;
        gameOver.SetActive(true);
        GameObject.Find("Score").GetComponent<Text>();
        finalScoreText.text = "Total Score\n" +_score;
        finalHighScoreText.text = "Highscore\n" +totalhighscore;
    }

    public void Damage()
    {
        heartCount = heartCount -1;
        //yield return?

        if(heartCount <= 0) // && !isDead)
        {
            // isDead = true;
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            GameOver = true;
            DoGameOver();
        }

        if(heartCount <1)
        {
            DoGameOver();
        }
        
    }

}
