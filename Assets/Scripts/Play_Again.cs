using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Again : MonoBehaviour
{
    public void playAgainFunc() {
		SceneManager.LoadScene(0);
	}
}
