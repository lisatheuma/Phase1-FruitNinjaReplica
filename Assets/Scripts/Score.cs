using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{

    public Transform player;
    public static int scoreamount;
    public static int totalhighscore;
    public Text scoreText;
    public Text highscoreText;
    public GameObject gameOver;
    public static bool GameOver = false;
    private UIManager _uiManager;

    void Start () 
    {
       //highscoreText.text = totalhighscore.ToString(); 
        _uiManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        //_uiManager.AddHighscore();
        //scoreText.text =  scoreamount.ToString();
        // if(scoreamount > totalhighscore)
        // {
        //     totalhighscore = scoreamount;
            
        // }else
        // {
        //     highscoreText.text = "" +totalhighscore;
        // }


        if(gameOver == true)
        {
            _uiManager.DoGameOver();

        }

    }
    
}
