using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Special0 : MonoBehaviour
{

    private GameObject _2XPrefab;
    public Text score;

    
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
        
        GameObject scoreamount = GameObject.Find("Scoreamount");
        //x2 score for each sliced object
            //Stop after a few seconds
    }
}
