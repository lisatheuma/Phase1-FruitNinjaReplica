using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{

    public Transform player;
    public static int scoreamount;
    public static int totalhighscore;
    public Text score;
    public Text highScore;
    public GameObject gameOver;
    public static bool GameOver = false;
    private UIManager _uiManager;

    void Start () 
    {
    score = GetComponent<Text>();
    highScore.text = totalhighscore.ToString();
    //highScore.text = PlayerPrefs.GetInt("HighScore", totalhighscore).ToString();
    }

    void Update()
    {
        score.text =  scoreamount.ToString();
        if(scoreamount > totalhighscore)
        {
            totalhighscore = scoreamount;
            //PlayerPrefs.SetInt("HighScore", totalhighscore);
            
        }else
        {
            highScore.text = "" +totalhighscore;
        }


        if(gameOver == true)
        {
            _uiManager.DoGameOver();
            // PlayerPrefs.SetInt("highscore", totalhighscore);
            // PlayerPrefs.Save();
        }

    }
    
}
