using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //private int _lives = 1;
    [SerializeField]
    public float distance = 1f;
    public bool useInitialCameraDistance = false;
    public bool isslicing = false;
    private float actualDistance;
    private float sliceDestroyTime;
    private Camera cam;
    private Vector2 swipeStart;
    CircleCollider2D circleCollider;

    void Start()
    {
        cam = Camera.main;
       // trail = GetComponent<TrailRenderer>();
        Cursor.visible = false;
        circleCollider = GetComponent<CircleCollider2D>();
        if(useInitialCameraDistance)
        {
            Vector3 toObjectVector = transform.position - Camera.main.transform.position;
            Vector3 linearDistanceVector = Vector3.Project(toObjectVector,Camera.main.transform.forward);
            actualDistance = linearDistanceVector.magnitude;
        }
        else
        {
            actualDistance = distance;
        }

    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = actualDistance;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
    

}

