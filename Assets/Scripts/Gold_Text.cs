using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold_Text : MonoBehaviour {
    public Text goldText = null;

    // Update is called once per frame
    void Update() {
        goldText.text = Coin_Script.totalCoins.ToString();
    }
}
