using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moon_Dialog_Controller : MonoBehaviour
{
    [SerializeField] private GameObject jerry_dialog = null;
    [SerializeField] private GameObject jerry_fight = null;
    [SerializeField] private GameObject jerry_fireGun = null;

    [SerializeField] private GameObject jerry_1 = null;
    [SerializeField] private GameObject jerry_2 = null;
    [SerializeField] private GameObject jerry_3 = null;
    [SerializeField] private GameObject isobelle_1 = null;
    [SerializeField] private GameObject harriet_1 = null;
    [SerializeField] private GameObject fade = null;


    [SerializeField] private float timer = 0.0f;
    [SerializeField] private float transition_1 = 0.0f;
    [SerializeField] private float transition_2 = 0.0f;
    [SerializeField] private float transition_3 = 0.0f;
    [SerializeField] private float transition_4 = 0.0f;
    [SerializeField] private float transition_Gameplay = 0.0f;
    [SerializeField] private float fireGun = 0.0f;
    [SerializeField] private float fadeTime = 0.0f;
    [SerializeField] private float harrietKilled = 0.0f;

    public static bool fightWon = false;

    private void Start() {
        jerry_2.SetActive(false);
        jerry_3.SetActive(false);
        isobelle_1.SetActive(false);
        harriet_1.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;

        if (timer > transition_1) {
            isobelle_1.SetActive(true);
            jerry_1.SetActive(false);
        }

        if (timer > transition_2) {
            harriet_1.SetActive(true);
            isobelle_1.SetActive(false);
        }

        if (timer > transition_3) {
            jerry_2.SetActive(true);
            harriet_1.SetActive(false);
        }

        if (timer > transition_4) {
            jerry_3.SetActive(true);
            jerry_2.SetActive(false);
        }

        if (timer > transition_Gameplay) {
            jerry_fight.SetActive(true);
            jerry_3.SetActive(false);
            jerry_dialog.SetActive(false);
        }

        if (timer > fireGun) {
            jerry_fireGun.SetActive(true);
		}

        if (timer > fadeTime) {
            fade.SetActive(true);
        }

        if (timer > harrietKilled) {
            fightWon = true;
        }

        if (fightWon == true) {
            SceneManager.LoadScene(5);
        }
    }
}
