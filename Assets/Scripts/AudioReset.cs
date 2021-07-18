﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioReset : MonoBehaviour
{
    [SerializeField] private float timer = 2.0f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0.1f) {
            gameObject.SetActive(false);
		}
    }
}
