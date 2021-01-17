using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentMoney;
    public static int sellerValue = 15;
    public GameObject sellerStats;
    public static int sellerCount;
    public static int sellPerSec;

    public GameObject GfakeButton;
    public GameObject GfakeText;
    public GameObject GrealButton;
    public GameObject GrealText;
    public static int gigValue;
    public GameObject peopleAnim;
    public GameObject gigTime;
    public GameObject gigTT;




    void Start()
    {

    }

    void Update()
    {


        currentMoney = GlobalMoney.MoneyCount;
        sellerStats.GetComponent<Text>().text = "Customers: " + sellerCount + " /s";
        fakeText.GetComponent<Text>().text = "Promote Music - $" + sellerValue;
        realText.GetComponent<Text>().text = "Promote Music - $" + sellerValue;
        if (currentMoney >= sellerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else if(currentMoney < sellerValue){
            fakeButton.SetActive(true);
            realButton.SetActive(false);

        }

        if(GlobalProducer.passiveMultiplier * GlobalProducer.passivePerSec > 1000000)
        {
            gigValue = (int)Math.Ceiling((10 + GlobalProducer.passivePerSec * GlobalProducer.passiveMultiplier) * 35.5);
        }
        else if (GlobalProducer.passiveMultiplier * GlobalProducer.passivePerSec > 100000)
        {
            gigValue = (int)Math.Ceiling((10 + GlobalProducer.passivePerSec * GlobalProducer.passiveMultiplier) * 30.5);
        }
        else if (GlobalProducer.passiveMultiplier * GlobalProducer.passivePerSec > 10000)
        {
            gigValue = (int)Math.Ceiling((10 + GlobalProducer.passivePerSec * GlobalProducer.passiveMultiplier) * 26.5);
        }
        else if (GlobalProducer.passiveMultiplier * GlobalProducer.passivePerSec > 1000)
        {
            gigValue = (int)Math.Ceiling((10 + GlobalProducer.passivePerSec * GlobalProducer.passiveMultiplier) * 18.5);
        }
        else
        {
            gigValue = (int)Math.Ceiling((10 + GlobalProducer.passivePerSec * GlobalProducer.passiveMultiplier) * 10.5);
        }

        GfakeText.GetComponent<Text>().text = "Attend a gig\n$" + gigValue;
        GrealText.GetComponent<Text>().text = "Attend a gig\n$" + gigValue;
        if (AutoGig.timeCount > 0)
        {
            GfakeButton.SetActive(false);
            GrealButton.SetActive(false);
            gigTT.SetActive(false);
            peopleAnim.SetActive(true);
        }
        else if (currentMoney >= gigValue)
        {
            GfakeButton.SetActive(false);
            GrealButton.SetActive(true);
            peopleAnim.SetActive(false);
        }
        else if (currentMoney < gigValue)
        {
            GfakeButton.SetActive(true);
            GrealButton.SetActive(false);
            peopleAnim.SetActive(false);

        }

        if(AutoGig.timeCount > 0)
        {
            gigTime.SetActive(true);
            gigTime.GetComponent<Text>().text = "Gig time left:\n" + AutoGig.timeCount;
        }
        else
        {
            gigTime.SetActive(false);
        }
    }
}
