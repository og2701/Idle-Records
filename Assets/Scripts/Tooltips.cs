using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Tooltips : MonoBehaviour
{

    public GameObject toolTip;
    public void HoverTrue()
    {
        toolTip.SetActive(true);

    }
    public void HoverFalse()
    {
        toolTip.SetActive(false);
    }
}
