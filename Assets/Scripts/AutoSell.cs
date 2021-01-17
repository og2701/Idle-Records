using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public bool CreatingSale = false;
    public static int MoneyIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        MoneyIncrease = GlobalShop.sellPerSec;
        InternalIncrease = MoneyIncrease;
        if(CreatingSale == false)
        {
            CreatingSale = true;
            StartCoroutine(CreateTheSale());
        }
    }

    IEnumerator CreateTheSale()
    {
        if (GlobalRecords.RecordCount < InternalIncrease)
        {
            
            CreatingSale = false;
        }
        else
        {
            GlobalMoney.MoneyCount += InternalIncrease * Endorsements.sellMultiplier;
            GlobalRecords.RecordCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            CreatingSale = false;
        }
        
    }
}
