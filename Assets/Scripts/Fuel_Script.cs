using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel_Script : MonoBehaviour
{
    public static float totalFuel = 100.0f;


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Total Fuel: " + totalFuel);
    }
}
