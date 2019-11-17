using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayLives : MonoBehaviour
{
    [SerializeField]
    private int Lifecount;
    [SerializeField]
    private GameObject _lifePrefab;

    private GameObject _life2Prefab;
    private GameObject Sushi;
    private List<GameObject> lives;

    [SerializeField]
    private GameObject scoreText, gameOver, highScoreText;
    
    void Start () 
    {
        lives = new List<GameObject> ();
        for (int lifeIndex = 0; lifeIndex < this.Lifecount; lifeIndex++) {
            GameObject life = Instantiate (_lifePrefab, this.gameObject.transform);
            lives.Add (life);
            }
    }
            
    public void looseLife() {

        this.Lifecount -= 1;
        GameObject life = this.lives [this.lives.Count - 1];
        this.lives.RemoveAt(this.lives.Count - 1);
        //index
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.color = Color.red;
        
        if (this.Lifecount == 0) 
        {
            this.scoreText.SetActive (false);
            Debug.Log("Game Over");
        }

    }

}
