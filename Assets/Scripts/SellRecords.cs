using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SellRecords : MonoBehaviour
{
    public GameObject statusBox;

    public void ClickerButton()
    {
        if(GlobalRecords.RecordCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough records to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnima");
        }
        else
        {
            GlobalRecords.RecordCount -= 1;
            GlobalMoney.MoneyCount += 1*Endorsements.sellMultiplier;
        }
        
    }
}
