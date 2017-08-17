﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ShopController : MonoBehaviour
{
    [Header("Shop Menu UI")]
    public GameObject BuyShipButtonGameObject;
    public GameObject ShopMenuGameObject;
    public GameObject HelpToolsGameObject;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void buyShipButton()
    { 
        BuyShipButtonGameObject.SetActive(true);
        ShopMenuGameObject.SetActive(false);
    }
    public void returnBuyShip()
    {
        BuyShipButtonGameObject.SetActive(false);
        ShopMenuGameObject.SetActive(true);
    }

    public void helpToolButton()
    {
        HelpToolsGameObject.SetActive(true);
        ShopMenuGameObject.SetActive(false);
    }
    public void returnHelpTool()
    {
        HelpToolsGameObject.SetActive(false);
        ShopMenuGameObject.SetActive(true);
    }

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }

    public void ShipOne()
    {
        if (PlayerPrefs.GetInt("money") > 2500)
        {
            PlayerPrefs.SetInt("ship", 1);
        }
    }
    public void ShipTwo()
    {
        if (PlayerPrefs.GetInt("money") > 2500)
        {
            PlayerPrefs.SetInt("ship", 2);
        }
    }
    public void ShipThree()
    {
        if (PlayerPrefs.GetInt("money") > 2500)
        {
            PlayerPrefs.SetInt("ship", 3);
        }
    }
    public void ShipFour()
    {
        if (PlayerPrefs.GetInt("money") > 2500)
        {
            PlayerPrefs.SetInt("ship", 4);
        }
    }
}
