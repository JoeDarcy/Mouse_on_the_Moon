using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    [SerializeField] private GameObject tankFlash = null;
    [SerializeField] private GameObject tankLeakEffect_1 = null;
    [SerializeField] private GameObject tankLeakEffect_2 = null;
    [SerializeField] private GameObject tankLeakEffect_3 = null;
    [SerializeField] private int hitCount = 0;
    [SerializeField] private int hitControl = 1;
    public static int armour = 1;
    public static bool leakActive = false;
    private float startingMaxFuel = 0.0f;
    private bool tankHit = false;
    [SerializeField] private float hitTimerStartingValue = 0.0f;
    [SerializeField] private float hitTimer = 0.0f;
    [SerializeField] private int flashCount = 0;
    private int currentflashCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        // Reset max fuel on restart
        if (Upgrades.doubleTank == true) {
            Fuel_Script.maxFuel = 200;
            Fuel_Script.totalFuel = Fuel_Script.maxFuel;

        }

        if (Upgrades.extraCapacity == true) {
            Fuel_Script.maxFuel *= 1.5f;
            Fuel_Script.totalFuel = Fuel_Script.maxFuel;
        }

        if (Upgrades.doubleTank != true && Upgrades.extraCapacity != true) {
            Fuel_Script.maxFuel = 100;
            Fuel_Script.totalFuel = Fuel_Script.maxFuel;
        }


        startingMaxFuel = Fuel_Script.maxFuel;

        hitCount = 0;

        tankLeakEffect_1.SetActive(false);
        tankLeakEffect_2.SetActive(false);
        tankLeakEffect_3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Tank flashing red on hit
        if (tankHit == true && currentflashCount > 0) {

            hitTimer -= Time.deltaTime;

            if (hitTimer < hitTimerStartingValue / 2) {
                tankFlash.SetActive(false);
            } else {
                tankFlash.SetActive(true);
            }  
            
            if (hitTimer < 0.01) {
                hitTimer = hitTimerStartingValue;
			}

            currentflashCount -= 1;
		} else {
            tankFlash.SetActive(false);
            tankHit = false;
            currentflashCount = flashCount;
        }

        // Apply armour multipier
        hitControl *= armour;

        // Check hit count to set leak activity 
        if (hitCount == 0) {
            leakActive = false;
		} else {
            leakActive = true;
		}

        if (hitCount == hitControl) {
            // Set correct effect true and others to false
            tankLeakEffect_1.SetActive(true);
            tankLeakEffect_2.SetActive(false);
            tankLeakEffect_3.SetActive(false);
            Fuel_Script.maxFuel = (startingMaxFuel / 4.0f) * 3.0f;
        } else if (hitCount == hitControl * 2) {
            tankLeakEffect_2.SetActive(true);
            tankLeakEffect_1.SetActive(false);
            tankLeakEffect_3.SetActive(false);
            Fuel_Script.maxFuel = (startingMaxFuel / 4.0f) * 2.0f;
        } else if (hitCount == hitControl * 3) {
            tankLeakEffect_3.SetActive(true);
            tankLeakEffect_1.SetActive(false);
            tankLeakEffect_2.SetActive(false);
            Fuel_Script.maxFuel = (startingMaxFuel / 4.0f) * 1.0f;
        }

        if (Fuel_Script.totalFuel < 0.1f) {
            tankLeakEffect_1.SetActive(false);
            tankLeakEffect_2.SetActive(false);
            tankLeakEffect_3.SetActive(false);
        }
    }

	private void OnTriggerEnter2D(Collider2D collision) {
        //Debug.Log("Collision with: " + collision);

        if (collision.tag == "Enemy") {
            //Debug.Log("Hit detected!");
            hitCount += 1;
            tankHit = true;
        }
    }
}
