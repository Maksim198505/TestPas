using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloverControlier : MonoBehaviour
{
    public float timeBeforeSpawningFlovers = 1.5f;
    public float timeBetweenFlovers = 0.25f;
    public float timeBeforeWavesFlovers = 2.0f;
    private int currentNumberOfFlovers = 0;
    public GameObject flovers;
    public int flover = 10;
    float randomX;
    private Vector3 whereToSpawnFlovers;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFlover());
    }

    // Update is called once per frame
    void Update()
    {
        SpawnFlover();
    }
    //Спавн цветов
    IEnumerator SpawnFlover() 
    {
        yield return new WaitForSeconds (timeBeforeSpawningFlovers);
        while(true) 
        {
            if (currentNumberOfFlovers <= 0) 
            {
                for (int i = 0; i < flover; i++)
                {
                    randomX = Random.Range(12.83f, -8.59f);
                    whereToSpawnFlovers = new Vector3(randomX, 0.76f);
                    Instantiate(flovers, whereToSpawnFlovers, Quaternion.identity);
                    currentNumberOfFlovers++;
                    yield return new WaitForSeconds (timeBetweenFlovers);
                }
            }
            yield return new WaitForSeconds (timeBeforeWavesFlovers);
        }   
        
    }

    
}
