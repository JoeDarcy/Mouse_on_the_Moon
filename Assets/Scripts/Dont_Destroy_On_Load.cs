﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont_Destroy_On_Load : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
