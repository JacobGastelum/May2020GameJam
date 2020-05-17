using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogClock : Clock
{

    public GameObject minuteHand;
    public GameObject hourHand;
    public GameObject pivotpoint;

    private float MINUTE_IN_A_HOUR = 60;
    private float HOUR_IN_A_DAY = 12;

    private Vector3 originalHourPos, originalMinPos;



    //This function updates the clock hands position so it accurately displays the right time.
    protected override void animClock()
    {

        float minuteRatio, hourRatio;
        float circleDegrees = 360f;

        minuteRatio = circleDegrees * ((float)minute / MINUTE_IN_A_HOUR);
        hourRatio = circleDegrees * ((float)hour / HOUR_IN_A_DAY);



        //resets the clock back to 12
        minuteHand.transform.eulerAngles = new Vector3(0, 0, 0);
        hourHand.transform.eulerAngles = new Vector3(0, 0, 0);
        hourHand.transform.position = originalHourPos;
        minuteHand.transform.position = originalMinPos;


        //Rotates the ca
        minuteHand.transform.RotateAround(pivotpoint.transform.position, Vector3.right, minuteRatio);
        hourHand.transform.RotateAround(pivotpoint.transform.position, Vector3.right, hourRatio);

    }


    //Player interacts to change the time of the clock. 
    public override void Interact()
    {
        if (Input.GetKeyDown("g"))
        {
            minute += 15;
            overflowProtection();
            animClock();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        originalHourPos = hourHand.transform.position;
        originalMinPos = minuteHand.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Interact();
    }

}
