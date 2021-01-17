using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker
    : MonoBehaviour
{
    public GameObject textBox;

    public void ClickerButton()
    {
        GlobalRecords.RecordCount += 1;
    }
}
