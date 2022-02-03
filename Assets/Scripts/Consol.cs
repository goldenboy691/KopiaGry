using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Consol : MonoBehaviour
{
    public TextMeshProUGUI consolOutput;

    //Comandy
    string comand1 = "1-Help 2-Robi coś 3-Robi coś 4 -Robi coś 5 -Robi coś";
    string comand2 = "Unity-2020.3.25f1 , version-alfa.04";
    string comand3 = "Comand1 -dsds Comand2 - Ssds";
    string comand4 = "Comand1 -dsds Comand2 - Ssds";
    string comand5 = "Comand1 -dsds Comand2 - Ssds";

    public void comandJeden()
    {
        //help
        consolOutput.text = comand1.ToString();
    }
    public void comandDwa()
    {
        //info
        consolOutput.text = comand2.ToString();
    }
    public void comandTrzy()
    {
        consolOutput.text = comand3.ToString();
    }
    public void comandCztery()
    {
        consolOutput.text = comand4.ToString();
    }
    public void comandPiec()
    {
        consolOutput.text = comand5.ToString();
    }
}
