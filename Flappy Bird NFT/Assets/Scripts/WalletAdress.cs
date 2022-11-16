using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WalletAdress : MonoBehaviour {

    public TextMeshProUGUI adressText;

    // Start is called before the first frame update
    void Start() {
        adressText.text += PlayerPrefs.GetString("Account");
    }

    // Update is called once per frame
    void Update() {

    }

}
