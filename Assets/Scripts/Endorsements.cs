using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Endorsements : MonoBehaviour
{
    public GameObject endorsementText;
    public GameObject winImage;

    public GameObject cCeleb;
    public GameObject bCeleb;
    public GameObject aCeleb;

    public GameObject cCelebButton;
    public GameObject bCelebButton;
    public GameObject aCelebButton;

    public GameObject fakecCelebButton;
    public GameObject fakebCelebButton;
    public GameObject fakeaCelebButton;

    public bool C = false;
    public bool B = false;
    public bool A = false;

    public static int sellMultiplier = 1;

    public TMP_Text popularityText;
    public int popularity;
    public double popularityCheck;

    public GameObject toolTip;

    

    void Update()
    {
        popularityCheck = Math.Round(Math.Log(GlobalShop.sellerCount) / Math.Log(159306) * 100);
        if(popularityCheck < 0)
        {
            popularityText.text = "Popularity: 0%";
        }
        else
        {
            popularity = (int)popularityCheck;
            popularityText.text = "Popularity: " + popularity + "%";
        }

        if (popularity >= 25 & C == false)
        {
            fakecCelebButton.SetActive(false);
            cCelebButton.SetActive(true);
        }
        if(popularity >= 50 & B == false)
        {
            fakebCelebButton.SetActive(false);
            bCelebButton.SetActive(true);
        }
        if(popularity >= 75 & A == false)
        {
            fakeaCelebButton.SetActive(false);
            aCelebButton.SetActive(true);
        }

        if(popularity >= 100)
        {
            winImage.SetActive(true);
        }

    }

    public void C_List()
    {
        sellMultiplier = 2;
        C = true;
        cCelebButton.SetActive(false);
        endorsementText.SetActive(true);
        cCeleb.SetActive(true);
        toolTip.SetActive(false);

        
    }

    public void B_List()
    {
        B = true;
        sellMultiplier = 3;
        bCelebButton.SetActive(false);
        endorsementText.SetActive(true);
        bCeleb.SetActive(true);
        toolTip.SetActive(false);
    }

    public void A_List()
    {
        A = true;
        sellMultiplier = 4;
        aCelebButton.SetActive(false);
        endorsementText.SetActive(true);
        aCeleb.SetActive(true);
        toolTip.SetActive(false);
    }



}

