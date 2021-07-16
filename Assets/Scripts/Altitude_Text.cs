using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Altitude_Text : MonoBehaviour
{
    public Text altitudeText = null;
    [SerializeField] private GameObject jerry = null;
    private float jerryAltitude = 0.0f;
    private string altitudeString = " ";

    // Update is called once per frame
    void Update()
    {
        jerryAltitude = jerry.transform.position.y;

        if (jerryAltitude < 0) {
            jerryAltitude = 0;
		}
        jerryAltitude /= 10;
        jerryAltitude = Mathf.Round(jerryAltitude * 10) / 10;

        altitudeString = jerryAltitude.ToString();

        altitudeText.text = altitudeString;
    }
}
