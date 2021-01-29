using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{

    public float TimeOffsetInMillis;
    public float SpawnDelay;
    public GameObject CarPrefab;
    public int numCars;

    private float lastSpawned;
    private float nextSpawn;
    private List<GameObject> CarPool;
    private int carNum;

    // Start is called before the first frame update
    void Start()
    {
        CarPool = new List<GameObject>(numCars);
        lastSpawned = Time.time;
        nextSpawn = lastSpawned + (TimeOffsetInMillis / 1000f);
        
        for(int i = 0; i < numCars; ++i)
        {
            CarPool.Add(Instantiate(CarPrefab, transform.position, Quaternion.identity, transform));
            CarPool[i].SetActive(false);
        }
        carNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < nextSpawn)
        {
            return;
        }
        UpdateSpawnTimer();
        CarPool[carNum++].SetActive(true);
        if (carNum >= numCars) carNum = 0;
    }

    void UpdateSpawnTimer()
    {
        lastSpawned = Time.time;
        nextSpawn = lastSpawned + SpawnDelay;
        Debug.Log("next Spawn time: " + nextSpawn);
    }
}
