using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Clock : MonoBehaviour
{
    protected int hour = 12;
    protected int minute = 0;

    protected bool am = true; // am is true , pm is false 

    //
    protected abstract void animClock(); // Animation when time changes
    protected void overflowProtection() // if hour > 12 or minute > 60 it goes back to 0;
    {
        if(minute >= 60)
        {
            hour += 1;
            minute %= 60;
        }
        
        if(hour > 12)
        {
            am = !am;
            hour %= 12;
        }

    }


    public void returnTime(out int hour, out int minute) // Return the Time 
    {
        hour = this.hour;
        minute = this.minute;
    }

    public abstract void Interact(); // player interact


}
