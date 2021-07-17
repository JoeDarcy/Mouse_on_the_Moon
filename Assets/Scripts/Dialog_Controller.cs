using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_Controller : MonoBehaviour
{
    [SerializeField] private GameObject jerry_1 = null;
    [SerializeField] private GameObject jerry_2 = null;
    [SerializeField] private GameObject jerry_3 = null;
    [SerializeField] private GameObject isobelle_1 = null;
    [SerializeField] private GameObject harriet_1 = null;


    [SerializeField] private float timer = 0.0f;
    [SerializeField] private float transition_1 = 0.0f;
    [SerializeField] private float transition_2 = 0.0f;
    [SerializeField] private float transition_3 = 0.0f;
    [SerializeField] private float transition_4 = 0.0f;


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
    }
}
