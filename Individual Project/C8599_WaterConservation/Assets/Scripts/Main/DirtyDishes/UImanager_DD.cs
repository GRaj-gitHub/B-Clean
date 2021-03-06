using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager_DD : MonoBehaviour
{
    
    [SerializeField]
    private GameObject waterField;
    [SerializeField]
    private GameObject secondField;
    [SerializeField]
    private GameObject minuteField;
    [SerializeField]
    private GameObject holdField;
    [SerializeField]
    private GameObject remainingField;
    [SerializeField]
    private GameObject cleanedField;


    void Update()
    {
        waterField.GetComponent<Text>().text = MainGame.waterPercentage + "%";

        if (Countdown.second < 10) 
            secondField.GetComponent<Text>().text = "0" + Countdown.second + "";
        else 
            secondField.GetComponent<Text>().text = Countdown.second + "";

        if (Countdown.minute < 10)
            minuteField.GetComponent<Text>().text = "0" + Countdown.minute + "" + ":"; 
        else 
            minuteField.GetComponent<Text>().text = Countdown.minute + "" + ":";

        holdField.GetComponent<Text>().text = "x " + MainGame.platecount;

        remainingField.GetComponent<Text>().text = "x " + MainGame.dirtyPlates;

        cleanedField.GetComponent<Text>().text = "x " + MainGame.cleanPlates;
    }

   

    
}
