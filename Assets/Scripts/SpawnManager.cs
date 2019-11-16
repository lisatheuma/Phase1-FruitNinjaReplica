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
    private GameObject[] _luckyCatPrefab;

    [SerializeField]
    private Sprite[] objectSprites;

    //private Transform[] spawnPoints;
    private bool _stopSpawning = false;
    public float sushiSpawn_time = 2f;
    public float sushiSpawn_delay = 5f;
    public float timeUntilSpawnIncrease = 30f;
    public float sushiSpawn_increase = 1f;

    public float spawnInterval, objectMinX, objectMaxX, objectY;

    void Start()
    {
        //InvokeRepeating("spawnSushi", this.spawnInterval, this.spawnInterval);
        InvokeRepeating("spawnSushi", sushiSpawn_delay, sushiSpawn_time);
        //StartCoroutine(TimeIncrease());
        //StartCoroutine(SpawnLuckyCatRoutine(5f));
        //InvokeRepeating("spawnLuckyCat", this.spawnInterval, this.spawnInterval);
    }

    //private void spawnLuckyCat()
    //{
    //    GameObject LuckyCat = Instantiate(_luckyCatPrefab);
    //    LuckyCat.transform.position = new Vector2(Random.Range(this.objectMinX, this.objectMaxX), this.objectY);
        //GameObject newEnemy = Instantiate(_enemyPrefab, spawnPos, Quaternion.identity);
        //    newEnemy.transform.SetParent(_enemyContainer.transform);
    //    yield return new WaitForSeconds(60);
    //}
    private void spawnSushi()
    {
        //While (_stopSpawning == false){
            GameObject Sushi = Instantiate(_sushiPrefab);
            
            //Random.Range for varying spawning times? To allow multiple objects to enter the screen together

            Sushi.transform.position = new Vector2(Random.Range(this.objectMinX, this.objectMaxX), this.objectY);
            Sushi.transform.SetParent(_sushiContainer.transform);
            //yield return new WaitForSeconds(delay);
            //Destroy(spawnedSushi, 5f);
            Sprite objectSprite = objectSprites[Random.Range (0, this.objectSprites.Length)];
            Sushi.GetComponent<SpriteRenderer>().sprite = objectSprite;
        //}
    }
    
    //IEnumerator TimeIncrease()
    //{
    //    while(_stopSpawning == false)
    //    {

    //    }
    //}



    public void StopSpawning()
    {
        CancelInvoke("spawnSushi");
    }
    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }
}
