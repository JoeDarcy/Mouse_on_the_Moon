using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_Out : MonoBehaviour
{

    [SerializeField] private GameObject fade = null;
    [SerializeField] private float timer = 0.0f;
    [SerializeField] private float setTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        timer = setTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0.1f) {
            timer = 0.0f;
            fade.SetActive(true);
		}
    }
}
