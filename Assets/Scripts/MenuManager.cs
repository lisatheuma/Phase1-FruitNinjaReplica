using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    void Start()
    {
        
        Time.timeScale = 1f;
        //stageCount.text = stageamount.ToString();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
        //stageamount = 0;
        //_score = 0;
    }

    void Update()
    {
        
    }
}
