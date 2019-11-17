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

	void Start ()
	{
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range (minYSpeed, maxYSpeed));
        Destroy(this.gameObject, this.destroyTime);
    }

    void Update()
    {
    }

    void OnCollisionEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
