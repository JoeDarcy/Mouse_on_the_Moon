using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Coin Collected");

        // Increment fuel
        Coin_Script.totalCoins += 1;

        Destroy(gameObject);
    }
}
