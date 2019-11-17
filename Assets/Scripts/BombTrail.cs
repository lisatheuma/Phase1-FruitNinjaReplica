using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTrail : MonoBehaviour
{
    private float timeBtwSpawns;
    public float startTimeBtwSpawms;

    public GameObject trail;
    public GameObject _bombPrefab;

    void Start()
    {
    }


    void Update()
    {
            GameObject instance = (GameObject)Instantiate(trail, transform.position, Quaternion.identity);
            Destroy(instance, 0.35f);
            timeBtwSpawns = startTimeBtwSpawms;
            //trail.transform.SetParent(_bombPrefab.transform);

            if(_bombPrefab == null)
            {
                Destroy(this.gameObject);
            }
            
    }
}
