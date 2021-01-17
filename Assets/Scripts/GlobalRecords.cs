using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalRecords : MonoBehaviour
{
    public static int RecordCount;
    public TMP_Text RecordDisplay;
    public int InternalRecord;

    void Update()
    {
        InternalRecord = RecordCount;
        RecordDisplay.text = "Records: " + InternalRecord;
    }
}
