using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour {

    [SerializeField] private string password = null;
    [SerializeField] private string permaPassword = null;
    [SerializeField] private GameObject passwordTick = null;
    public static bool freeGoldUnlock = false;
    public static bool permaUnlock = false;

    [SerializeField] private InputField inputField = null;
    private string passwordEntered = " ";


    private void Update() {     

        if (permaUnlock == true) {
            passwordTick.SetActive(false);
            freeGoldUnlock = true;
        }

        MyFunction();
	}

	void MyFunction() {
        //Debug.Log(inputField.text);
        passwordEntered = inputField.text;

        if (passwordEntered == password) {
            //Debug.Log("Password accepted");
            passwordTick.SetActive(false);
            freeGoldUnlock = true;
            inputField.text = "";
        }

        if (passwordEntered == permaPassword) {
            //Debug.Log("Password accepted");
            permaUnlock = true;
            passwordTick.SetActive(false);
            freeGoldUnlock = true;
            inputField.text = "";
        }
    }
}
