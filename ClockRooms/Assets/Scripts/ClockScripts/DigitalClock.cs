using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DigitalClock : Clock
{
    public bool militaryClock;
    public TextMeshPro text;

    public override void Interact()
    {
        throw new System.NotImplementedException();
    }

    protected override void animClock()
    {

        string hourText;
        string minuteText;
        if(hour < 10)
        {
            hourText = "0" + hour.ToString();
        }
        else
        {
            hourText = hour.ToString();
        }

        if (minute < 10)
        {
            minuteText = "0" + minute.ToString();
        }
        else
        {
            minuteText = minute.ToString();
        }

        text.SetText(hourText + ":" + minuteText);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animClock();
    }
}
