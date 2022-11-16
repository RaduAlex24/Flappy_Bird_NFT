using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class WebGLSendTransactionExample : MonoBehaviour {


    public TextMeshProUGUI hashText;


    async public void OnSendTransaction() {
        // account to send to
        string to = "0xD518ba2e2147f16de82F5d39708125693701033C";
        // amount in wei to send
        string value = "50000000000000000";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to send a transaction
        try {
            string response = await Web3GL.SendTransaction(to, value, gasLimit, gasPrice);
            Debug.Log(response);
            hashText.text = response;
        }
        catch (Exception e) {
            Debug.LogException(e, this);
        }
    }



    private void Update() {
        if (hashText.text.Contains("0")) {
            SceneManager.LoadScene(2);
        }
    }


}