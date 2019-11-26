using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Hearts : MonoBehaviour
{

    public int startingHearts;
    private int heartCount;

    [SerializeField]
    private Text _hearts;
    private GameObject _sushiPrefab;
    public GameObject gameOver;
    public static bool GameOver = false;
    public bool isDead;

    void Start()
    {
        _hearts = GetComponent<Text>();
        heartCount = startingHearts;
    }

    // Update is called once per frame
    void Update()
    {
        if(heartCount <= 0 && !isDead)
        {
            isDead = true;
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            GameOver = true;
        }

        _hearts.text = "x" + heartCount;

    }

    public void minusHeart()
    {
        heartCount--;
    }
        //if sushi falls out of bounds
        //lose lifes minusHeart()  

}
