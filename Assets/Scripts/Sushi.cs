using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi : MonoBehaviour
{

    private GameObject _SushiPrefab;
    public GameObject slicedSushiPrefab;
    [SerializeField]
    private float minXSpeed, maxXSpeed, minYSpeed, maxYSpeed;
    [SerializeField]
    private float destroyTime;

    private GameObject selectedObject;
    private Vector3 position;

	void Start ()
	{
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range (minYSpeed, maxYSpeed));
        Destroy(this.gameObject, this.destroyTime);
    }

    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Score.scoreamount += 1;
        }    
    }
}
