using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi : MonoBehaviour
{

    private GameObject _sushiPrefab;

    [SerializeField]
    private float minXSpeed, maxXSpeed, minYSpeed, maxYSpeed;
    [SerializeField]
    private float destroyTime;
    private GameObject selectedObject;
    private Vector3 position;

    private int heartCount;

    private Stagecounter _counter;

    private BoxCollider2D _collider;

    [SerializeField]
    private GameObject[] _targetPrefabs;

	void Start ()
	{
        int index = Random.Range(0, _targetPrefabs.Length);
        _counter = FindObjectOfType<Stagecounter>();
        _collider = GetComponent<BoxCollider2D>();
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
                Score.scoreamount += 1;
                _counter.AddScore();
            }
            Destroy(this.gameObject);
        }
    }

}
