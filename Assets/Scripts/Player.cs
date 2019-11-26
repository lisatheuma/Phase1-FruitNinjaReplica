using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private int _lives = 3;
    [SerializeField]
    public float distance = 1f;
    public bool useInitialCameraDistance = false;
    public bool isslicing = false;
    private float actualDistance;
    //private float sliceDestroyTime;
    private Camera cam;
    private Vector2 swipeStart;
    CircleCollider2D circleCollider;

    //private float speed = 1.0f;
    public static float unscaledTime;

    

    void Start()
    {
        cam = Camera.main;
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
        unscaledTime = Time.unscaledTime;
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = actualDistance;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);


        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);


        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float angle = AngleBetweenTwoPoints(transform.position, mouseOnScreen);
        transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));
    }
    float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}

