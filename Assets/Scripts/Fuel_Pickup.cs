using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel_Pickup : MonoBehaviour
{
    public static bool fuelAudioTrigger = false;
    [SerializeField] private float fuelAmount = 10.0f;

    [SerializeField] private GameObject fuelAudio = null;

	private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Player") {
            //Debug.Log("Fuel Collected");
            // Increment fuel
            if (Fuel_Script.totalFuel + fuelAmount < Fuel_Script.maxFuel) {
                Fuel_Script.totalFuel += fuelAmount;
            } else {
                Fuel_Script.totalFuel += ((Fuel_Script.totalFuel + fuelAmount) - Fuel_Script.maxFuel);
            }

            Instantiate(fuelAudio, transform.position, Quaternion.identity);

            fuelAudioTrigger = true;

            Destroy(gameObject);
        }
	}
}
