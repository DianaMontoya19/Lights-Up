using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawn;
    public float spawnTimer;
    public float spawnMax = 3;
    public float spawnMin = 1;
    void Start()
    {
        spawnTimer = Random.Range(spawnMin, spawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            Instantiate(spawn);
            spawnTimer = Random.Range(spawnMin, spawnMax);
        }
        
    }
}
