using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    private GameObject _BombPrefab;
    
    [SerializeField]
    private float minXSpeed, maxXSpeed, minYSpeed, maxYSpeed;
    [SerializeField]
    private float destroyTime;

    public GameObject gameOver;
    public static bool GameOver = false;
    public bool isDead;

    private CircleCollider2D _collider;

    private UIManager _uiManager;

	void Start ()
	{
        _uiManager = FindObjectOfType<UIManager>();

        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range (minYSpeed, maxYSpeed));
        Destroy(this.gameObject, this.destroyTime);
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
                _uiManager.DoGameOver();
                Destroy(this.gameObject);
            }
        }    
    }

}
