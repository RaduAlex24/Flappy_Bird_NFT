using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ERC721OwnerOfExample : MonoBehaviour {


    public GameObject RedFlappy;

    public TextMeshProUGUI walletUser;
    public TextMeshProUGUI ownerAdress;


    async public void Check721NFT() {
        string chain = "binance";
        string network = "mainnet";
        string contract = "0xcB0cbcE06860f6C30C62560f5eFBF918150e056E";
        string tokenId = "1";

        string ownerOf = await ERC721.OwnerOf(chain, network, contract, tokenId);
        print(ownerOf);

        ownerAdress.text = ownerOf;
    }


    private void Update() {
        string ownerAdressString = ownerAdress.text.ToLower();

        if (ownerAdressString.Equals(walletUser.text)) {
            RedFlappy.SetActive(true);
            SceneManager.LoadScene(3);
        }

    }

}
