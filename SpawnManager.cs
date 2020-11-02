using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Reference to animal array
    public GameObject[] animalPrefabs;
    // Animal spawn range (x-axis)
    private float spawnRangeX = 15;
    // Animal spawn position (z-axis)
    private float spawnPosZ = 20;
    // Animal spawn start delay
    private float startDelay = 2;
    // Animal spawn interval
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Call SpawnRandomAnimal function after delay and interval
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Function that spawns random animals 
    void SpawnRandomAnimal()
    {

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        // Create random int from 0 to length of animalprefab array.  animalIndex
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Instantiate gameObjects
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
