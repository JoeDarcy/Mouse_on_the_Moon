using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launchpad : MonoBehaviour
{
    [SerializeField] private GameObject jerry = null;
	[SerializeField] private bool explosionArmed = false;
	[SerializeField] private GameObject explosion = null;
	[SerializeField] private GameObject explosionAudio = null;


	private void OnTriggerExit2D(Collider2D collision) {
			explosionArmed = true;
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		//Debug.Log("Triggered by " + collision);
		if (explosionArmed == true) {
			explosion.SetActive(true);
			jerry.SetActive(false);
			Fuel_Script.totalFuel = 0;

			Instantiate(explosionAudio, transform.position, Quaternion.identity);
		}
	}
}
