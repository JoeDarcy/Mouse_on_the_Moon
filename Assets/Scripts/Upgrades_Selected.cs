using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades_Selected : MonoBehaviour
{
    [SerializeField] private GameObject doubleTank = null;
    [SerializeField] private GameObject extraCapacity = null;
    [SerializeField] private GameObject extraEfficiency = null;
    [SerializeField] private GameObject armour = null;
    [SerializeField] private GameObject booster = null;
    [SerializeField] private GameObject slowFall = null;
    [SerializeField] private GameObject hover = null;
    [SerializeField] private GameObject infiniteFuel = null;

    // Start is called before the first frame update
    void Start()
    {
        doubleTank.SetActive(true);
        extraCapacity.SetActive(true);
        extraEfficiency.SetActive(true);
        armour.SetActive(true);
        booster.SetActive(true);
        slowFall.SetActive(true);
        hover.SetActive(true);
        infiniteFuel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Upgrades.doubleTank == true) {
            doubleTank.SetActive(false);
        }

        if (Upgrades.extraCapacity == true) {
            extraCapacity.SetActive(false);
        }

        if (Upgrades.extraEfficiency == true) {
            extraEfficiency.SetActive(false);
        }

        if (Upgrades.armour == true) {
            armour.SetActive(false);
        }

        if (Upgrades.booster == true) {
            booster.SetActive(false);
        }

        if (Upgrades.slowFall == true) {
            slowFall.SetActive(false);
        }

        if (Upgrades.hover == true) {
            hover.SetActive(false);
        }

        if (Upgrades.infiniteFuel == true) {
            infiniteFuel.SetActive(false);
        }
    }
}
