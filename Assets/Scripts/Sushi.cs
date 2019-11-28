using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi : MonoBehaviour
{    
    [SerializeField]
    private float minXSpeed, maxXSpeed, minYSpeed, maxYSpeed;
    [SerializeField]
    private float destroyTime;
    private GameObject selectedObject;
    private Vector3 position;
    private int heartCount;
    private UIManager _uiManager;

	void Start ()
	{
        _uiManager = FindObjectOfType<UIManager>();
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range (minYSpeed, maxYSpeed));

        Destroy(this.gameObject, this.destroyTime);
    }

    void Update() 
    {
        
        if(transform.position.y <= -7)
        {
            _uiManager.Damage();
        }
    }  

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                //Score.scoreamount += 1;
                // Score.scoreamount += 1;
                _uiManager.AddScore();
                Destroy(gameObject);
            }
        }
    }

}
