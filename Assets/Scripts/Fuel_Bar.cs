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
        fuelPercentage = (Fuel_Script.adjustedTotalFuel / Fuel_Script.adjustedMaxFuel) * 100;
        fuelPercentage /= 10;

        if(Upgrades.doubleTank == true) {
            fuelPercentage /= 2;
		}

        if (Upgrades.extraCapacity == true) {
            fuelPercentage -= fuelPercentage / 2;
        }

        fuelBar.transform.localScale = new Vector3(transform.localScale.x, fuelPercentage, transform.localScale.z);
        
    }
}
