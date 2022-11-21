using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class WebGLSendContractExample : MonoBehaviour {


    public TextMeshProUGUI confirmationText;


    async public void OnSendContract() {
        // smart contract method to call
        string method = "addTotal";
        // abi in json format
        string abi = "[ { \"inputs\": [ { \"internalType\": \"uint8\", \"name\": \"_myArg\", \"type\": \"uint8\" } ], \"name\": \"addTotal\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"myTotal\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" } ]";

        // Cica e aceelasi abi
        //[ { "inputs": [ { "internalType": "uint8", "name": "_myArg", "type": "uint8" } ], "name": "addTotal", "outputs": [], "stateMutability": "nonpayable", "type": "function" }, { "inputs": [], "name": "myTotal", "outputs": [ { "internalType": "uint256", "name": "", "type": "uint256" } ], "stateMutability": "view", "type": "function" } ]

        // address of contract
        string contract = "0xF040f654d5a2Bee6019047F7892CF6BCE7E1a920";
        // array of arguments for contract
        string args = "[\"1\"]";
        // value in wei
        string value = "0";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
        try {
            string response = await Web3GL.SendContract(method, abi, contract, args, value, gasLimit, gasPrice);
            Debug.Log(response);

            // Put the respose in the text
            confirmationText.text = response;

        }
        catch (Exception e) {
            Debug.LogException(e, this);
        }
    }


    private void Update() {
        if (confirmationText.text.Contains("0")) {
            SceneManager.LoadScene(6);
        }
    }


}
