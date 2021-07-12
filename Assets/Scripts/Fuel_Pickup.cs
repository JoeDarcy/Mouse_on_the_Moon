﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel_Pickup : MonoBehaviour
{
    [SerializeField] private float fuelAmount = 10.0f;

	private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Fuel Collected");

        // Increment fuel
        Fuel_Script.totalFuel += fuelAmount;

        Destroy(gameObject);
	}
}
