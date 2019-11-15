using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi : MonoBehaviour
{

    private GameObject _SushiPrefab;
    public GameObject slicedSushiPrefab;
    private float _sushispeed = 4f;
    private Vector3 randomPosition = new Vector3 (Random.Range(-1,1), Random.Range(0.3f,0.7f), Random.Range(-6.5f, -7.5f));


	void Start ()
	{
	}

    void Update()
    {
        if(gameObject.transform.position.y < -7.3)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            //Destroy(gameObject);
        }
    }

}
