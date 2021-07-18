using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
	[SerializeField] private int sceneNumber = 2;


	public void PlayGame() {
		SceneManager.LoadScene(sceneNumber);
	}
}
