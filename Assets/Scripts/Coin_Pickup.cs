using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Player") {
            //Debug.Log("Coin Collected");
            //Debug.Log("Collision with: " + collision);

            // Increment fuel
            Coin_Script.totalCoins += 1;

            Destroy(gameObject);
        }
    }
}
