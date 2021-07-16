using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuel_Total_Text : MonoBehaviour
{
    public Text fuelTotalText = null;

    // Update is called once per frame
    void Update() {
        fuelTotalText.text = Fuel_Script.totalFuel.ToString("F0");
    }
}
