using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller_End : MonoBehaviour
{
    [SerializeField] private GameObject reunion = null;
    [SerializeField] private GameObject hearts = null;
    [SerializeField] private GameObject wink = null;
    [SerializeField] private GameObject look = null;
    [SerializeField] private GameObject fade = null;

    [SerializeField] private float timer = 0.0f;
    [SerializeField] private float transition_1 = 0.0f;
    [SerializeField] private float transition_2 = 0.0f;
    [SerializeField] private float transition_3 = 0.0f;
    [SerializeField] private float fadeTime = 0.0f;
    [SerializeField] private float endSceneTransition = 0.0f;

    [SerializeField] private Camera cam = null;
    [SerializeField] private GameObject camAnimator = null;
    private Animator animator = null;

    private void Start() {
        reunion.SetActive(false);
        hearts.SetActive(false);
        animator = camAnimator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;

        if (timer > transition_1) {
            reunion.SetActive(true);
            hearts.SetActive(true);
            if (cam.orthographicSize > 2) {
                cam.orthographicSize -= 0.001f;
                animator.enabled = true;
            }          
        }

        if (timer > transition_2) {
            wink.SetActive(true);
            look.SetActive(true);
        }

        if (timer > transition_3) {
            wink.SetActive(false);
            look.SetActive(false);
        }

        if (timer > fadeTime) {
            fade.SetActive(true);
		}

        if (timer > endSceneTransition) {
            SceneManager.LoadScene(6);
        }
    }
}
