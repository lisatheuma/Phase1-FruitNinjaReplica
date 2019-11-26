using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi : MonoBehaviour
{

    private GameObject _sushiPrefab;
    public GameObject slicedSushiPrefab;
    [SerializeField]
    private float minXSpeed, maxXSpeed, minYSpeed, maxYSpeed;
    [SerializeField]
    private float destroyTime;
    private GameObject selectedObject;
    private Vector3 position;

    private int heartCount;

    private Stagecounter _counter;

    private BoxCollider2D _collider;


	void Start ()
	{
        _counter = FindObjectOfType<Stagecounter>();
        _collider = GetComponent<BoxCollider2D>();
        
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range (minYSpeed, maxYSpeed));
        
        Destroy(this.gameObject, this.destroyTime);
    }

    void Update()
    {
        //if sushi falls out of bounds
        //lose lifes minusHeart()  
        if(transform.position.y < 6.9)
        {
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                Score.scoreamount += 1;
                _counter.AddScore();
            }
            Destroy(this.gameObject);
        }
    }

}
