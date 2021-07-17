using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel_Bar : MonoBehaviour
{
    [SerializeField] private GameObject fuelBar = null;
    [SerializeField] private Vector3 fuelScale = new Vector3(0, 10, 0);
    [SerializeField] private float fuelPercentage = 100.0f;
    private float startingMaxFuel = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        fuelBar.transform.localScale = fuelScale;

        startingMaxFuel = Fuel_Script.maxFuel;
    }

    // Update is called once per frame
    void Update()
    {
        

        fuelPercentage = (Fuel_Script.totalFuel / Fuel_Script.maxFuel) * 100;
        fuelPercentage /= 10;
        
        if (Fuel_Script.maxFuel <= (startingMaxFuel * 0.75) && Fuel_Script.maxFuel > (startingMaxFuel * 0.50)) {
            fuelPercentage *= 0.75f;
		} else if (Fuel_Script.maxFuel <= (startingMaxFuel * 0.50) && Fuel_Script.maxFuel > (startingMaxFuel * 0.25)) {
            fuelPercentage *= 0.50f;
        } else if(Fuel_Script.maxFuel <= (startingMaxFuel * 0.25)) {
            fuelPercentage *= 0.25f;
        }

        fuelBar.transform.localScale = new Vector3(transform.localScale.x, fuelPercentage, transform.localScale.z);
    }
}
