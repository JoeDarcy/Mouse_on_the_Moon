﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Again : MonoBehaviour
{
	[SerializeField] private int sceneNumber = 0;

	public void PlayAgainFunc() {
		Password.freeGoldUnlock = false;

		if (Password.permaUnlock == true) {
			Password.freeGoldUnlock = true;
		}

		SceneManager.LoadScene(sceneNumber);
	}
}
