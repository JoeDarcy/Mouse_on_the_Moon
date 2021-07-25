using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner : MonoBehaviour
{
    [SerializeField] private GameObject coin = null;
    [SerializeField] private float startTimer = 0.0f;
    [SerializeField] private float spawnTimer = 0.0f;
    [SerializeField] private float spawnRate = 0.0f;
    public GameObject instance = null;

    // Update is called once per frame
    void Update() {
        if (startTimer > 0.0f) {
            startTimer -= Time.deltaTime;
        }

        if (startTimer < 0.1f) {
            if (spawnTimer > 0.0f) {
                spawnTimer -= Time.deltaTime;
            }
        }

        if (instance == null) {           
            if (spawnTimer < 0.1f) {
                instance = Instantiate(coin, new Vector3(transform.position.x, transform.position.y, -10), Quaternion.identity);
                spawnTimer = spawnRate;
            }
        }
    }
}
