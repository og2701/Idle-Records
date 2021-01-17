using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalProducer : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;

    public GameObject SfakeButton;
    public GameObject SfakeText;
    public GameObject SrealButton;
    public GameObject SrealText;

    public int currentMoney;
    public static int producerValue = 15;
    public static int supervisorValue = 50;
    public GameObject producerStats;
    public GameObject supervisorStats;
    public static int producerCount;
    public static int supervisorCount;
    public static int passivePerSec;
    public static int passiveMultiplier = 1;

    void Start()
    {

    }

    void Update()
    {
        currentMoney = GlobalMoney.MoneyCount;
        producerStats.GetComponent<Text>().text = "Producers: " + producerCount + " (" + (passivePerSec*passiveMultiplier) + " /s)";
        fakeText.GetComponent<Text>().text = "Hire Producer - $" + producerValue;
        realText.GetComponent<Text>().text = "Hire Producer - $" + producerValue;
        if (currentMoney >= producerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else if(currentMoney < producerValue){
            fakeButton.SetActive(true);
            realButton.SetActive(false);

        }

        supervisorStats.GetComponent<Text>().text = "Supervisors: " + supervisorCount;
        SfakeText.GetComponent<Text>().text = "Hire Supervisor - $" + supervisorValue;
        SrealText.GetComponent<Text>().text = "Hire Supervisor - $" + supervisorValue;
        if (currentMoney >= supervisorValue)
        {
            SfakeButton.SetActive(false);
            SrealButton.SetActive(true);
        }
        else if (currentMoney < supervisorValue)
        {
            SfakeButton.SetActive(true);
            SrealButton.SetActive(false);

        }
    }
}
