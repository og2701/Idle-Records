using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalMoney : MonoBehaviour
{
    public static int MoneyCount;
    public TMP_Text MoneyDisplay;
    public int InternalMoney;

    void Update()
    {
        InternalMoney = MoneyCount;
        MoneyDisplay.text = "$" + InternalMoney;
    }
}
