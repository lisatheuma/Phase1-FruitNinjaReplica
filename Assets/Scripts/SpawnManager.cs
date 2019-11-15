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
    private GameObject _bombPrefab;            

    [SerializeField]
    private GameObject _bombContainer;   

    [SerializeField]
    private GameObject[] _LuckyCatPrefab;

    [SerializeField]
    private Sprite[] objectSprites;

    private Transform[] spawnPoints;
    private bool _stopSpawning = false;

    public float minDelay = 0.2f;
    public float maxDelay = 1f;

    
    private Vector3 throwForce = new Vector3 (0, 18, 0);

    void Start()
    {
        InvokeRepeating("SpawnSushi", 0.5f, 6);
        StartCoroutine(SpawnSushiRoutine());
       // StartCoroutine(SpawnBombRoutine());
       // StartCoroutine(SpawnLuckyCatRoutine());
    }

    IEnumerator SpawnSushiRoutine()
    {
      while (_stopSpawning == false)
        {
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            GameObject spawnedSushi = Instantiate(_sushiPrefab, spawnPoint.position, Quaternion.identity);
            
            float delay = Random.Range(minDelay,maxDelay);
            spawnedSushi.transform.SetParent(_sushiContainer.transform);
            yield return new WaitForSeconds(delay);
            //Destroy(spawnedSushi, 5f);

            //Sprite objectSprite = objectSprites [Random.Range(0,this.objectSprites.Length)];
            //newObject.GetComponent<SpriteRenderer>().sprite = objectSprite;
        }
    }
  
    
   public void OnPlayerDeath()
   {
       _stopSpawning = true;
   }
}
