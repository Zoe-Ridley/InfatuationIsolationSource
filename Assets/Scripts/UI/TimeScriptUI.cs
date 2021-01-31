using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScriptUI : MonoBehaviour
{
    // Our variables
    public Text timerText;
    private float secondsCount;
    private int minutesCount;
    void Update()
    {
        Timer();
    }
    public void Timer()
    {
        // This lets the seconds count up in real time with Delta time.
        secondsCount += Time.deltaTime;
        // This lets us show minutes and seconds for our timer
        timerText.text = "Timer: " + minutesCount + "m:" + (int)secondsCount + "s";
        // If the seconds reaches 60 seconds, it adds 1 to the minute and resets back to 0
        if (secondsCount >= 60)
        {
            minutesCount++;
            secondsCount = 0;
        }
    }
}

// Staffs Unnamed - GGJ Code