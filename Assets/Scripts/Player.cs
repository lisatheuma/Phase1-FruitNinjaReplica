using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //private int _lives = 1;
    //private TrailRenderer trail;
    //bool isSlice = false;
    public float distance = 1f;
    public bool useInitialCameraDistance = false;
    private float actualDistance;
    private Camera cam;
    void Start()
    {
        cam = Camera.main;
       // trail = GetComponent<TrailRenderer>();
        Cursor.visible = false;
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

    //public void Damage
    //{  
    //    if (_lives < 1)
    //    {
    //        _spawnManager.OnPlayerDeath();
    //        Destroy(this.gameObject);
    //}

}

