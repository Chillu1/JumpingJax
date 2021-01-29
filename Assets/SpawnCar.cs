using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{

    public float TimeOffsetInMillis;
    public float SpawnDelay;
    public GameObject CarPrefab;

    private float lastSpawned;
    private float nextSpawn;

    // Start is called before the first frame update
    void Start()
    {
        BoxCollider myCollider = GetComponent<BoxCollider>();
        myCollider.isTrigger = false;
        lastSpawned = Time.time;
        nextSpawn = lastSpawned + (TimeOffsetInMillis / 1000f);
        Debug.Log("initial Spawn time: " + lastSpawned);
        Debug.Log("next Spawn time: " + nextSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < nextSpawn)
        {
            return;
        }
        UpdateSpawnTimer();
        Instantiate(CarPrefab, transform);
    }

    void UpdateSpawnTimer()
    {
        lastSpawned = Time.time;
        nextSpawn = lastSpawned + SpawnDelay;
        Debug.Log("next Spawn time: " + nextSpawn);
    }
}
