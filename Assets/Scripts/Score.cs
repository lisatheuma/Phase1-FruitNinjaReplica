using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{


    public Transform player;
    public static int scoreamount = 0;
    public Text score;

    public Text highScore;

    void OnTriggerEnter(Collider other) 
    {
    
    }
    void Start () 
    {
    score = GetComponent<Text>();
    highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    void Update()
    {
        score.text =  scoreamount.ToString();;
        if(scoreamount > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreamount);

        }

        //if player dies, reset score
    }
    
}
