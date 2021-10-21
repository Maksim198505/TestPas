using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float timeBeforeSpawning = 1.5f;
    public float timeBetweenEnemies = 0.25f;
    public float timeBeforeWaves = 2.0f;
    private int currentNumberOfEnemies = 0;
    public GameObject enemy;
    public int bee = 20;
    float randomX;
    float randomY;
    private Vector2 whereToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }
    //Спавн пчел на сцене
    public IEnumerator SpawnEnemy() 
    {
        yield return new WaitForSeconds (timeBeforeSpawning);
        while(true) 
        {
            if (currentNumberOfEnemies <= 0) 
            {
                for (int i = 0; i < bee; i++)
                {
                    randomX = Random.Range(6.83f, -10.59f);
                    randomY = Random.Range(-3.5f, 3.50f);
                    whereToSpawn = new Vector2(randomX, randomY);
                    Instantiate(enemy, whereToSpawn, Quaternion.identity);
                    currentNumberOfEnemies++;
                    yield return new WaitForSeconds (timeBetweenEnemies);
                }
            }
            yield return new WaitForSeconds (timeBeforeWaves);
        }   
        
    }

    public void KilledEnemy()
    {
        currentNumberOfEnemies--;
    }

}
