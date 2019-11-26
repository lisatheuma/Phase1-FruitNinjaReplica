using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliceBomb : MonoBehaviour
{

    public GameObject gameOver;
    public static bool GameOver = false;
    public bool isDead;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
            isDead = true;
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            GameOver = true;
            Destroy(this.gameObject);
            //game over
            }
        }    
    }
}
