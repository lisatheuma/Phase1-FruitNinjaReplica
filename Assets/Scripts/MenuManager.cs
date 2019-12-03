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
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }

    void Update()
    {
        
    }
}
