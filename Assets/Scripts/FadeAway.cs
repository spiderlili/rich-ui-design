using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeAway : MonoBehaviour {
    private CountdownTimer countdownTimer;
    private Text textUI;
    public int fadeDuration = 3;
    private bool fading = false;

	// Use this for initialization
	void Start () {
        textUI = GetComponent<Text>();
        countdownTimer = GetComponent<CountdownTimer>();
        StartFading(fadeDuration);
	}

    // in each frame, tests if the fading variable is true. 
    // If it is true, then the alpha of the color of the Text-hello object is set to a value between 0.0 and 1.0, based on the proportion of the time remaining in the CountdownTimer object. 
    void Update () {
        if (fading) {
            float alphaRemaining = countdownTimer.GetProportionTimeRemaining();
            print(alphaRemaining);
            Color c = textUI.material.color;
            c.a = alphaRemaining;
            textUI.material.color = c;

            //stop fading when very small number
            if (alphaRemaining < 0.01) {
                fading = false;
            }
        }
    }
    //starts this timer scripted component to countdown to the given number of seconds
    public void StartFading(int timerTotal)
    {
        countdownTimer.ResetTimer(timerTotal);
        fading = true;
    }
}
