using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy = null;
    [SerializeField] private float startTimer = 0.0f;
    [SerializeField] private float spawnTimer = 0.0f;
    [SerializeField] private float spawnRate = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (startTimer > 0.0f) {
            startTimer -= Time.deltaTime;
        }

        if (startTimer < 0.1f) {
            if (spawnTimer > 0.0f) {
                spawnTimer -= Time.deltaTime;
            }
        }
        
        if (spawnTimer < 0.1f) {
            Instantiate(enemy, transform.position, Quaternion.identity);
            spawnTimer = spawnRate;
		}


    }
}
