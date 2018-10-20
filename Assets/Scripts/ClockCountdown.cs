using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ClockCountdown : MonoBehaviour {
    private Text textClock;
    private float countdownTimerDuration;
    private float countdownTimerStartTime;

	// Use this for initialization
	void Start () {
        textClock = GetComponent<Text>();
        CountdownTimerReset(30); //reset timer
	}
	
	// Update is called once per frame
	void Update () {
        //default - timer finished
        string timerMessage = "countdown has finished";
        int timeLeft = (int)countdownTimerSecondsRemaining();

        if (timeLeft > 0) { }
        timerMessage = "Countdown seconds remaining = " + LeadingZero(timeLeft);
        textClock.text = timerMessage;
    }

    void CountdownTimerReset(float delayInSeconds) {
        countdownTimerDuration = delayInSeconds;
        countdownTimerStartTime = Time.time;
 
    }

    float countdownTimerSecondsRemaining() {
        float elapsedSeconds = Time.time - countdownTimerStartTime;
        float timeLeft = countdownTimerDuration - elapsedSeconds;
        return timeLeft;
    }

    private string LeadingZero(int n) {
        return n.ToString().PadLeft(2, '0');
    }
}
