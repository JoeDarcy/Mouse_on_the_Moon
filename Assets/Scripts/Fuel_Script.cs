using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel_Script : MonoBehaviour
{
    public static float maxFuel = 100.0f;
    public static float totalFuel = 100.0f;

	private void Awake() {
		totalFuel = maxFuel;
	}
	// Update is called once per frame
	void Update()
    {
		if (totalFuel > maxFuel) {
			totalFuel = maxFuel;
		}

        //Debug.Log("Total Fuel: " + totalFuel);
		//Debug.Log("Max Fuel: " + maxFuel);
	}
}
