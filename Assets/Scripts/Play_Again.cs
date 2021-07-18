using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Again : MonoBehaviour
{
	[SerializeField] private int sceneNumber = 0;
	[SerializeField] private GameObject fadeToBlack = null;
	[SerializeField] private float timer = 0.0f;
	[SerializeField] private float setTimer = 0.0f;
	private bool fadeTriggered = false;

	private void Start() {
		fadeTriggered = false;
	}

	private void Update() {
		if (fadeTriggered == true) {
			timer -= Time.deltaTime;

			if (timer < 0.1f) {
				timer = setTimer;
				SceneManager.LoadScene(sceneNumber);
			}
		}		
	}

	public void PlayAgainFunc() {
		Password.freeGoldUnlock = false;

		if (Password.permaUnlock == true) {
			Password.freeGoldUnlock = true;
		}

		fadeToBlack.SetActive(true);

		fadeTriggered = true;
	}
}
