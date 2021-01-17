using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRecord : MonoBehaviour
{
    public bool CreatingRecord = false;
    public static int RecordIncrease = 1;
    public int InternalIncrease ;

    void Update()
    {
        RecordIncrease = GlobalProducer.passivePerSec;
        InternalIncrease = RecordIncrease;
        if(CreatingRecord == false)
        {
            CreatingRecord = true;
            StartCoroutine(CreateTheRecord());
        }
    }

    IEnumerator CreateTheRecord()
    {
        GlobalRecords.RecordCount += InternalIncrease*GlobalProducer.passiveMultiplier;
        yield return new WaitForSeconds(1);
        CreatingRecord = false;
    }
}
