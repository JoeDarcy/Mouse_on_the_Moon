using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel_Bar : MonoBehaviour
{
    [SerializeField] private GameObject fuelBar = null;
    [SerializeField] private Vector3 fuelScale = new Vector3(0, 10, 0);
    [SerializeField] private float fuelPercentage = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        fuelBar.transform.localScale = fuelScale;
    }

    // Update is called once per frame
    void Update()
    {
        fuelPercentage = (Fuel_Script.totalFuel / Fuel_Script.maxFuel) * 100;
        fuelPercentage /= 10;

        fuelBar.transform.localScale = new Vector3(transform.localScale.x, fuelPercentage, transform.localScale.z);
        
    }
}
