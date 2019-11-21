using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuckyCatSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject _luckyCatPrefab;

    //private Transform[] spawnPoints;
    private bool _stopSpawning = false;
    //public float luckCaySpawn_time = 2f;
    //public float luckyCatSpawn_delay = 5f;
    //public float timeUntilSpawnIncrease = 30f;

    public float spawnInterval, objectMinX, objectMaxX, objectY;

    void Start()
    {
        //StartCoroutine(SpawnLuckyCatRoutine(5f));
        //InvokeRepeating("spawnLuckyCat", luckyCatSpawn_delay, luckCaySpawn_time);
        InvokeRepeating("spawnLuckyCat", this.spawnInterval, this.spawnInterval);
    }

    private void spawnLuckyCat()
    {
        GameObject LuckyCat = Instantiate(_luckyCatPrefab);
        LuckyCat.transform.position = new Vector2(Random.Range(this.objectMinX, this.objectMaxX), this.objectY);
        //GameObject _luckyCatPrefab= Instantiate(_luckyCatPrefab, spawnPos, Quaternion.identity);
        //newLuckyCat.transform.SetParent(_luckyCatContainer.transform);
        //yield return new WaitForSeconds(60);
    }
    
    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }
}
