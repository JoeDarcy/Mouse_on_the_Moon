using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    [SerializeField] private int gold = 0;
    [SerializeField] private bool doubleTank = false;
    [SerializeField] private bool extraCapacity = false;
    [SerializeField] private bool extraEfficiency = false;
    [SerializeField] private bool armour = false;
    [SerializeField] private bool booster = false;
    [SerializeField] private bool slowFall = false;
    [SerializeField] private bool hover = false;
    [SerializeField] private bool infiniteFuel = false;

	private void Update() {
        gold = Coin_Script.totalCoins;
	}

	public void addGold() {
        Coin_Script.totalCoins += 5;
	}

    public void doubleTankFunc() {
        if (Coin_Script.totalCoins >= 5 && doubleTank == false) {
            doubleTank = true;
            Coin_Script.totalCoins -= 5;
        }
	}

    public void extraCapacityFunc() {
        if (Coin_Script.totalCoins >= 10 && extraCapacity == false) {
            extraCapacity = true;
            Coin_Script.totalCoins -= 10;
        }
    }

    public void extraEfficiencyFunc() {
        if (Coin_Script.totalCoins >= 15 && extraEfficiency == false) {
            extraEfficiency = true;
            Coin_Script.totalCoins -= 15;
        }
    }

    public void armourFunc() {
        if (Coin_Script.totalCoins >= 20 && armour == false) {
            armour = true;
            Coin_Script.totalCoins -= 20;
        }
    }

    public void boosterFunc() {
        if (Coin_Script.totalCoins >= 25 && booster == false) {
            booster = true;
            Coin_Script.totalCoins -= 25;
        }
    }

    public void slowFallFunc() {
        if (Coin_Script.totalCoins >= 30 && slowFall == false) {
            slowFall = true;
            Coin_Script.totalCoins -= 30;
        }
    }

    public void hoverFunc() {
        if (Coin_Script.totalCoins >= 35 && hover == false) {
            hover = true;
            Coin_Script.totalCoins -= 35;
        }
    }

    public void infiniteFuelFunc() {
        if (Coin_Script.totalCoins >= 40 && infiniteFuel == false) {
            infiniteFuel = true;
            Coin_Script.totalCoins -= 40;
        }
    }
}
