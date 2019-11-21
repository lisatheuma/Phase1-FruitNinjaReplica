using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliceBomb : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            GameObject Lives = GameObject.Find("Lives");
            Lives.GetComponent<DisplayLives> ().looseLife();
        }    
    }
}
