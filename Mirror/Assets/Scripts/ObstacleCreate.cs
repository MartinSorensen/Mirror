using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{
    public GameObject[] obstacles = new GameObject[3];
    public GameObject spawnObject;
    private Transform spawnLocation;
    public float maxTime = 3;
    public float minTime = 0.2f;
    public float xSpawnOffset = 33.0f;
    public float ySpawnOffset = 0.5f;
    public float zTopSpawnOffset = 0.1f;
    public float zBotSpawnOffset = 10.1f;
    public bool controlSpawnSizes = true;
    public bool controlSpawnPosition = true;
    private int randomIndexer;
    private bool locationCtrl = true;
    private int lastRandomIndexer = 0;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    void Start()
    {
        SetRandomness();
        spawnLocation = spawnObject.GetComponent<Transform>();
        time = minTime;

    }

    void FixedUpdate()
    {
        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SetRandomness();
            SpawnObject(locationCtrl);
        }

    }

    //Spawns the object and resets the time
    void SpawnObject(bool locationCtrl)
    {
        time = 0;

        if (locationCtrl == true)
        {
            Instantiate(obstacles[randomIndexer], new Vector3(spawnLocation.position.x + xSpawnOffset, spawnLocation.position.y + ySpawnOffset, spawnLocation.position.z + zTopSpawnOffset + (obstacles[randomIndexer].GetComponent<Transform>().localScale.z * 0.5f)), Quaternion.identity);
            Instantiate(obstacles[randomIndexer], new Vector3(spawnLocation.position.x + xSpawnOffset, spawnLocation.position.y + ySpawnOffset, spawnLocation.position.z - zTopSpawnOffset - (obstacles[randomIndexer].GetComponent<Transform>().localScale.z * 0.5f)), Quaternion.identity);
        }
        else if (locationCtrl == false)
        {
            Instantiate(obstacles[randomIndexer], new Vector3(spawnLocation.position.x + xSpawnOffset, spawnLocation.position.y + ySpawnOffset, spawnLocation.position.z + zBotSpawnOffset - (obstacles[randomIndexer].GetComponent<Transform>().localScale.z * 0.5f)), Quaternion.identity);
            Instantiate(obstacles[randomIndexer], new Vector3(spawnLocation.position.x + xSpawnOffset, spawnLocation.position.y + ySpawnOffset, spawnLocation.position.z - zBotSpawnOffset + (obstacles[randomIndexer].GetComponent<Transform>().localScale.z * 0.5f)), Quaternion.identity);
        }
    }

    //Sets the random time between minTime and maxTime
    void SetRandomness()
    {
        spawnTime = Random.Range(minTime, maxTime);

        randomIndexer = Random.Range(0, 3);
        if (randomIndexer == 2 && lastRandomIndexer == 2 && controlSpawnSizes)
        {
            randomIndexer = Random.Range(0, 2);
        }

        lastRandomIndexer = randomIndexer;

        if (locationCtrl)
            locationCtrl = false;
        else
            locationCtrl = true;
    }
}