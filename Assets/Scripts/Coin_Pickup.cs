using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Pickup : MonoBehaviour
{
    [SerializeField] private GameObject coinAudio = null;


    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Player") {
            Debug.Log("Coin Collected");
            Debug.Log("Collision with: " + collision);

            // Increment fuel
            Coin_Script.totalCoins += 1;

            Instantiate(coinAudio, transform.position, Quaternion.identity);

            Destroy(gameObject);

        }
    }
}
