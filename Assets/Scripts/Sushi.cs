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

    [SerializeField] private SushiSplit _leftHalf;
    
    [SerializeField] private SushiSplit _rightHalf;

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
            Destroy(this.gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                _uiManager.AddScore();

                SushiSplit left = Instantiate(_leftHalf, transform.position, Quaternion.identity);
                left.PushToSide(-1);

                SushiSplit right = Instantiate(_rightHalf, transform.position, Quaternion.identity);
                right.PushToSide(1);

                Destroy(gameObject);
            }
        }
    }

}
