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
    private GameObject[] _LuckyCatPrefab;

    [SerializeField]
    private Sprite[] objectSprites;

    //private Transform[] spawnPoints;
    private bool _stopSpawning = false;

    public float spawnInterval, objectMinX, objectMaxX, objectY;

    void Start()
    {
        InvokeRepeating("spawnSushi", this.spawnInterval, this.spawnInterval);
       // StartCoroutine(SpawnSushiRoutine());
       // StartCoroutine(SpawnLuckyCatRoutine());
    }

    //IEnumerator SpawnSushiRoutine()
    private void spawnSushi()
    {
            GameObject Sushi = Instantiate(_sushiPrefab);
            
            //Random.Range for varying spawning times? To allow multiple objects to enter the screen together

            Sushi.transform.position = new Vector2(Random.Range(this.objectMinX, this.objectMaxX), this.objectY);
            //spawnedSushi.transform.SetParent(_sushiContainer.transform);
            //yield return new WaitForSeconds(delay);
            //Destroy(spawnedSushi, 5f);
            Sprite objectSprite = objectSprites[Random.Range (0, this.objectSprites.Length)];
            Sushi.GetComponent<SpriteRenderer>().sprite = objectSprite;
    }
    
    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }
}
