using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyLog : MonoBehaviour
{
    public GameObject AutoRecord;
    public GameObject AutoSell;
    public GameObject statusBox;
    public GameObject GigScript;

    public void StartAutoRecord()
    {
        AutoRecord.SetActive(true);
        GlobalMoney.MoneyCount -= GlobalProducer.producerValue;
        GlobalProducer.producerValue *= 2;
        GlobalProducer.passivePerSec += 1;
        GlobalProducer.producerCount += 1;
        statusBox.GetComponent<Text>().text = "Hired a producer.";
        statusBox.GetComponent<Animation>().Play("StatusAnima");
    }


    public void StartAutoSell()
    {
        AutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= GlobalShop.sellerValue;
        GlobalShop.sellerValue = (int)Math.Floor(GlobalShop.sellerValue * 1.8);
        if(GlobalShop.sellerCount == 0)
        {
            GlobalShop.sellerCount = 1;
        }
        GlobalShop.sellerCount = (int)Math.Round(GlobalShop.sellerCount * 1.5);
        GlobalShop.sellPerSec = GlobalShop.sellerCount;
        statusBox.GetComponent<Text>().text = "Promoted music.";
        statusBox.GetComponent<Animation>().Play("StatusAnima");
    }

    public void StartSupervisor()
    {
        GlobalMoney.MoneyCount -= GlobalProducer.supervisorValue;
        GlobalProducer.passiveMultiplier = (int)Math.Round(GlobalProducer.passiveMultiplier * 1.8);
        GlobalProducer.supervisorCount += 1;
        GlobalProducer.supervisorValue = (int)Math.Floor(GlobalProducer.supervisorValue * 2.5);
        statusBox.GetComponent<Text>().text = "Hired supervisor.";
        statusBox.GetComponent<Animation>().Play("StatusAnima");
    }

    public void StartGig()
    {
        GigScript.SetActive(true);
        AutoGig.timeCount = 30;
        GlobalMoney.MoneyCount -= GlobalShop.gigValue;
        GlobalMoney.MoneyCount += GlobalRecords.RecordCount;
        GlobalRecords.RecordCount = 0;
        statusBox.GetComponent<Text>().text = "Attended a gig.";
        statusBox.GetComponent<Animation>().Play("StatusAnima");
        

    }


}
