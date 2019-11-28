using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField]
    private GameObject _sushiContainer;

    [SerializeField]
    public GameObject[] targetPrefabs;
    private bool _stopSpawning = false;
    public float sushiSpawn_time = 2f;
    public float sushiSpawn_delay = 5f;
    public float timeUntilSpawnIncrease = 30f;
    public float sushiSpawn_increase = 1f;

    public float spawnInterval, objectMinX, objectMaxX, objectY;

    // private int heartCount;

    // [SerializeField]
    // private Text _hearts;
    // private Hearts _Hearts;
    
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
            //this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range (minYSpeed, maxYSpeed));

            /// Destroy(this.gameObject, this.destroyTime);
            
            //sushi.transform.position = new Vector2(Random.Range(this.objectMinX, this.objectMaxX), this.objectY);
            
            //Instantiate (_targetPrefabs[index], Random.Range(-1f, 1f), Random.Range(-2f, 0));

            // Sushi.transform.SetParent(_sushiContainer.transform);
            // Sprite objectSprite = objectSprites[Random.Range (0, this.objectSprites.Length)];
            // Sushi.GetComponent<SpriteRenderer>().sprite = objectSprite;
    }
    
    void Update() 
    {
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
