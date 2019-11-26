using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Stagecounter : MonoBehaviour
{
    SpriteRenderer _stageCounterFill;
    public Image stageCounterFill;
    bool m_CounterFillAnim;
    private GameObject _sushiPrefab;
    public Text stageCount;
    public static int stageamount = 0;
    private int _cutSushi = 0;
    public static bool GameOver = false;
    public static bool GamePaused = false;
    public GameObject gameOver;
    public int startingHearts;
    private int heartCount;

    [SerializeField]
    private Text _hearts;
    public bool isDead;
    private UIManager _uiManager;

    void Start()
    {
        _hearts = GetComponent<Text>();
        heartCount = startingHearts;
    }
    void Update()
    {
        if(heartCount <= 0 && !isDead)
        {
            isDead = true;
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            GameOver = true;
            _uiManager.DoGameOver();
        }

        _hearts.text = "x" + heartCount;

        //-1 heart when sushi passes a certain position
        if(transform.position.y < 6.9)
        {
            heartCount--;
        }
    }

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

}
