using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Scene : MonoBehaviour
{
	[SerializeField] private int sceneNumber = 0;
	[SerializeField] private GameObject fade = null;
	private bool triggered = false;
	[SerializeField] private float timer = 0.0f;
	[SerializeField] private float setTimer = 0.0f;


	private void Start() {
		triggered = false;
	}

	private void Update() {
		if (triggered == true) {
			timer -= Time.deltaTime;

			if (timer < 0.1f) {
				SceneManager.LoadScene(sceneNumber);
				timer = setTimer;
			}
		}

		if (timer < 0.1f) {
			SceneManager.LoadScene(sceneNumber);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		//Debug.Log("Fade triggered");
		fade.SetActive(true);
		triggered = true;
	}
}
