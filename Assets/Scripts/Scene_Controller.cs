using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller : MonoBehaviour
{
    [SerializeField] private GameObject jerrySad = null;
    [SerializeField] private GameObject jerryAngry = null;
    [SerializeField] private GameObject hearts = null;
    [SerializeField] private GameObject gun = null;

    [SerializeField] private float timer = 0.0f;
    [SerializeField] private float transition_1 = 0.0f;
    [SerializeField] private float transition_2 = 0.0f;
    [SerializeField] private float transition_3 = 0.0f;
    [SerializeField] private float endSceneTransition = 0.0f;


    private void Start() {
        jerrySad.SetActive(false);
        jerryAngry.SetActive(false);
        gun.SetActive(false);
    }

	// Update is called once per frame
	void Update()
    {
        timer += Time.deltaTime;

        if (timer > transition_1) {
            jerrySad.SetActive(true);
            hearts.SetActive(false);
        }

        if (timer > transition_2) {
            jerryAngry.SetActive(true);
		}

        if (timer > transition_3) {
            gun.SetActive(true);
		}

        if (timer > endSceneTransition) {
            SceneManager.LoadScene(2);
        }
    }
}
