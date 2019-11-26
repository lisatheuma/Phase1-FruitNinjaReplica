using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Stagecounter : MonoBehaviour
{
    SpriteRenderer _stageCounterFill;
    public Image stageCounterFill;
    private Animation m_Animator;
    bool m_CounterFillAnim;
    private GameObject _sushiPrefab;
    public Text stageCount;
    public Text heartsCount;
    public static int stageamount = 1;

    private int _cutSushi = 0;

    [SerializeField]    
    private float currentSpeed;
    public static bool GameOver = false;
    public static bool GamePaused = false;
    public GameObject gameOver;

    public void AddScore()
    {
        _cutSushi++;

        if (_cutSushi >= stageamount)
        {
            _cutSushi -= stageamount;
            stageamount++;
        }

        stageCounterFill.fillAmount = (float) _cutSushi / (float) stageamount;
        stageCount.text = stageamount.ToString();
    }

    public void OnPlayerDeath()
    {
        Time.timeScale = 0f;
        GamePaused = true;
        GameOver = true;
        
    }

}
