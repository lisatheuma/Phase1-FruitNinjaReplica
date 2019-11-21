using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{


    public Transform player;
    public static int scoreamount = 0;
    Text score;

    void Start () 
    {
    score = GetComponent<Text>();
    }

    void Update()
    {
        score.text = "SCORE: " + scoreamount.ToString();;
    }
    
}
