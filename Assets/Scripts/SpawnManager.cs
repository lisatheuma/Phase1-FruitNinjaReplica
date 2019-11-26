using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour

    {

    [SerializeField]
    private GameObject _sushiPrefab;

    [SerializeField]
    private GameObject _sushiContainer;

    [SerializeField]
    private GameObject[] _targetPrefabs;
    private bool _stopSpawning = false;
    public float sushiSpawn_time = 2f;
    public float sushiSpawn_delay = 5f;
    public float timeUntilSpawnIncrease = 30f;
    public float sushiSpawn_increase = 1f;

    public float spawnInterval, objectMinX, objectMaxX, objectY;

    void Start()
    {
        InvokeRepeating("spawnSushi", sushiSpawn_delay, sushiSpawn_time);
    }
    private void spawnSushi()
    {
            int index = Random.Range(0, _targetPrefabs.Length);
            GameObject Sushi = Instantiate(_sushiPrefab);
           // index.transform.position = new Vector2(Random.Range(this.objectMinX, this.objectMaxX), this.objectY);
            Sushi.transform.SetParent(_sushiContainer.transform);
            //Sprite objectSprite = objectSprites[Random.Range (0, this.objectSprites.Length)];
            //Sushi.GetComponent<SpriteRenderer>().sprite = objectSprite;
    }
    



    public void StopSpawning()
    {
        CancelInvoke("spawnSushi");
    }
    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }
}
