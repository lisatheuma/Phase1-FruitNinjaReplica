using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour

    {

    [SerializeField]
    private GameObject _bombPrefab;            

    [SerializeField]
    private GameObject _bombContainer;   

    private bool _stopSpawning = false;

    public float spawnInterval, objectMinX, objectMaxX, objectY;

    void Start()
    {
        InvokeRepeating("spawnBomb", this.spawnInterval, this.spawnInterval);
    }
    
    private void spawnBomb()
    {
            GameObject Bomb = Instantiate(_bombPrefab);
            Bomb.transform.position = new Vector2(Random.Range(this.objectMinX, this.objectMaxX), this.objectY);
            //spawnedSushi.transform.SetParent(_sushiContainer.transform);
            //yield return new WaitForSeconds(delay);
            //Destroy(spawnedSushi, 5f);
    }

    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }
}
