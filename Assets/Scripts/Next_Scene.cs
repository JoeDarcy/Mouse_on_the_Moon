using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Scene : MonoBehaviour
{
	[SerializeField] private int sceneNumber = 0;

	private void OnTriggerEnter2D(Collider2D collision) {
		SceneManager.LoadScene(sceneNumber);
	}
}
