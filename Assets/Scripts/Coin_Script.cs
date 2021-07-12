using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Script : MonoBehaviour
{
    public static int totalCoins = 0;


    // Update is called once per frame
    void Update() {
        Debug.Log("Total Coins: " + totalCoins);
    }
}
