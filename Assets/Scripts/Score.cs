using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{


    public Transform player;
    public static int scoreamount = 0;
    public Text score;
    public Text endTotalScore;
    public Text highScore;
    public Text endHighScore;
    public GameObject gameOver;
    public static bool GameOver = false;

    void OnTriggerEnter(Collider other) 
    {
    
    }
    void Start () 
    {
    score = GetComponent<Text>();
    highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    endHighScore.text = PlayerPrefs.GetInt("EndHighScore", 0).ToString();
    endTotalScore.text = PlayerPrefs.GetInt("EndTotalScore", 0).ToString();
    scoreamount = 0;
    }

    void Update()
    {
        score.text =  scoreamount.ToString();;
        if(scoreamount > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreamount);

        }

        if(gameOver == true)
        {
            //reset score
            scoreamount = 0;
        }
 
    }
    
}
