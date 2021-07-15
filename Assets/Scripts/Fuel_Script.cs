using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel_Script : MonoBehaviour
{
    public static float maxFuel = 100.0f;
    public static float totalFuel = 100.0f;
    public static float adjustedMaxFuel = 100.0f;
    public static float adjustedTotalFuel = 100.0f;


    // Update is called once per frame
    void Update()
    {

        adjustedMaxFuel = maxFuel;
        adjustedTotalFuel = totalFuel;


  //      if (Upgrades.doubleTank == false && Upgrades.extraCapacity == false) {
  //          adjustedMaxFuel = maxFuel;
  //          adjustedTotalFuel = totalFuel;
		//}

  //      if(Upgrades.doubleTank == true) {
  //          maxFuel *= 2.0f;
  //          adjustedMaxFuel = maxFuel / 2.0f;
  //          adjustedTotalFuel = totalFuel / 2.0f;
		//}
        
  //      if (Upgrades.extraCapacity == true) {
  //          maxFuel += 100.0f; ;
  //          adjustedMaxFuel = maxFuel - 100.0f;
  //          adjustedTotalFuel = totalFuel - 100.0f;
  //      }

        Debug.Log("Total Fuel: " + totalFuel);
    }
}
