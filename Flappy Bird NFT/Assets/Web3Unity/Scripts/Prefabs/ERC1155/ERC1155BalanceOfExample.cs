using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ERC1155BalanceOfExample : MonoBehaviour {


    public GameObject GoldenFlappy;

    
    async public void CheckNFT() {

        // Golden flappy goerli
        //string chain = "ethereum";
        //string network = "goerli";
        //string contract = "0xf4910C763eD4e47A585E2D34baA9A4b611aE448C";
        //string account = PlayerPrefs.GetString("Account"); //"0x844338eE103F0c3E390B0CEA9c7Bc9E3aF0590f9";
        //string tokenId = "59824067682304975106095494595492311412760405414591883723135499139845787222017";


        // Golden falppy smart chain 
        string chain = "binance";
        string network = "testnet";
        string contract = "0x4f0c6f5601C4f85b7E7960149a2A2c4eCa0C0835";
        string account = PlayerPrefs.GetString("Account"); //"0x844338eE103F0c3E390B0CEA9c7Bc9E3aF0590f9";
        string tokenId = "1";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0) {
            GoldenFlappy.SetActive(true);
            SceneManager.LoadScene(4);
        }

    }
}
