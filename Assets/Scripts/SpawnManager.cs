using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField]
    public GameObject[] targetPrefabs;
    private bool _stopSpawning = false;
    public float sushiSpawn_time = 3f;
    public float sushiSpawn_delay = 2f;
    
    public float objectMinX, objectMaxX, objectY;

    void Start()
    {
        InvokeRepeating("spawnSushi", sushiSpawn_delay, sushiSpawn_time);
    }  
    private void spawnSushi()
    {
            int index = Random.Range(0, this.targetPrefabs.Length);
            Vector2 location = new Vector2 (Random.Range(this.objectMinX, this.objectMaxX), this.objectY);
            GameObject targetPrefab = targetPrefabs[Random.Range(0,targetPrefabs.Length)];
            var newTargetPrefab = Instantiate(targetPrefab);
            newTargetPrefab.transform.position = new Vector2(Random.Range(this.objectMinX, this.objectMaxX), this.objectY);
    }
    
    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }
        public void StopSpawning()
    {
        CancelInvoke("spawnSushi");
    }
}
