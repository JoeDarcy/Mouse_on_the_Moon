using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    [SerializeField] private int gold = 0;
    [SerializeField] private float fuel = 0.0f;
    [SerializeField] public static bool doubleTank = false;
    [SerializeField] public static bool extraCapacity = false;
    [SerializeField] public static bool extraEfficiency = false;
    [SerializeField] public static bool armour = false;
    [SerializeField] public static bool booster = false;
    [SerializeField] public static bool slowFall = false;
    [SerializeField] public static bool hover = false;
    [SerializeField] public static bool infiniteFuel = false;

    // Tick game objects
    [SerializeField] private GameObject doubleTankTick = null;
    [SerializeField] private GameObject extraCapacityTick = null;
    [SerializeField] private GameObject extraEfficiencyTick = null;
    [SerializeField] private GameObject armourTick = null;
    [SerializeField] private GameObject boosterTick = null;
    [SerializeField] private GameObject slowFallTick = null;
    [SerializeField] private GameObject hoverTick = null;
    [SerializeField] private GameObject infiniteFuelTick = null;

    // Update and display fuel and gold
    private void Update() {
        fuel = Fuel_Script.totalFuel;
        gold = Coin_Script.totalCoins;
	}


	public void AddGold() {
        Coin_Script.totalCoins += 5;
	}

    public void DoubleTankFunc() {
        if (Coin_Script.totalCoins >= 5 && doubleTank == false) {
            doubleTank = true;
            Fuel_Script.totalFuel *= 2;
            Fuel_Script.maxFuel *= 2;
            Coin_Script.totalCoins -= 5;
            doubleTankTick.SetActive(true);
        }
	}

    public void ExtraCapacityFunc() {
        if (Coin_Script.totalCoins >= 10 && extraCapacity == false) {
            extraCapacity = true;
            Fuel_Script.totalFuel *= 1.5f;
            Fuel_Script.maxFuel *= 1.5f;
            Coin_Script.totalCoins -= 10;
            extraCapacityTick.SetActive(true);
        }
    }

    public void ExtraEfficiencyFunc() {
        if (Coin_Script.totalCoins >= 15 && extraEfficiency == false) {
            extraEfficiency = true;
            Jerry_Movement.burnRate /= 2;
            Coin_Script.totalCoins -= 15;
            extraEfficiencyTick.SetActive(true);
        }
    }

    public void ArmourFunc() {
        if (Coin_Script.totalCoins >= 20 && armour == false) {
            armour = true;
            Coin_Script.totalCoins -= 20;
            armourTick.SetActive(true);
        }
    }

    public void BoosterFunc() {
        if (Coin_Script.totalCoins >= 25 && booster == false) {
            booster = true;
            Coin_Script.totalCoins -= 25;
            boosterTick.SetActive(true);
        }
    }

    public void SlowFallFunc() {
        if (Coin_Script.totalCoins >= 30 && slowFall == false) {
            slowFall = true;
            Coin_Script.totalCoins -= 30;
            slowFallTick.SetActive(true);
        }
    }

    public void HoverFunc() {
        if (Coin_Script.totalCoins >= 35 && hover == false) {
            hover = true;
            Coin_Script.totalCoins -= 35;
            Jerry_Movement.fallSpeed = 0.0001f;
            hoverTick.SetActive(true);
        }
    }

    public void InfiniteFuelFunc() {
        if (Coin_Script.totalCoins >= 40 && infiniteFuel == false) {
            infiniteFuel = true;
            Fuel_Script.totalFuel = 1000000.0f;
            Coin_Script.totalCoins -= 40;
            infiniteFuelTick.SetActive(true);
        }
    }
}
