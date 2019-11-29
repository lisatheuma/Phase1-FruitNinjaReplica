using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiSplit : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void PushToSide(int direction)
    {
        direction = (int) Mathf.Sign(direction);
        rb.AddForce(Vector2.right * direction, ForceMode2D.Impulse);
    
    }

    void Update()
    {
        if(transform.position.y <= -7)
        {
            Destroy(this.gameObject);
        }
    }

    

}
