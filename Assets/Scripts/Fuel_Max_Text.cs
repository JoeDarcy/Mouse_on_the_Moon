using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuel_Max_Text : MonoBehaviour
{
    public Text fuelMaxText = null;

    // Update is called once per frame
    void Update()
    {
        fuelMaxText.text = Fuel_Script.maxFuel.ToString();
    }
}
