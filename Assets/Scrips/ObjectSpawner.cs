using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject fallingObject;
    public float spawnRate = 1f;
    public float minX = -8f;
    public float maxX = 8f;

    

    private void Start()
    {
        InvokeRepeating("SpawnObject", 1f, spawnRate);
    }

    void SpawnObject()
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, transform.position.z);
        Instantiate(fallingObject, spawnPosition, Quaternion.identity);
    }
}