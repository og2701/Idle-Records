using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGig : MonoBehaviour
{
    public static int timeCount;
    public GameObject GfakeButton;
    public GameObject GrealButton;
    public bool atGig = false;

    void Update()
    {
        if(atGig == false)
        {
            atGig = true;
            StartCoroutine(SellAll());
        }
    }

    IEnumerator SellAll()
    {
        if(timeCount >= 0)
        {
            if (timeCount % 5 == 0)
            {
                GlobalMoney.MoneyCount += GlobalRecords.RecordCount * Endorsements.sellMultiplier;
                GlobalRecords.RecordCount = 0;
            }
            yield return new WaitForSeconds(1);
            timeCount -= 1;
        }
        atGig = false;


    }
}