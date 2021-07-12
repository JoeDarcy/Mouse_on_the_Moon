using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altimeter : MonoBehaviour
{
    [SerializeField] private GameObject jerry = null;
    [SerializeField] private float altitude = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        altitude = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        altitude = jerry.transform.position.y;
    }
}
