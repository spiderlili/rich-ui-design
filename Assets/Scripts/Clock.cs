using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

//Important: Horizontal and Vertical Overflow settings set to Overflow
public class Clock : MonoBehaviour {
    private Text textClock;
	// Use this for initialization
	void Start () {
        textClock = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        DateTime time = DateTime.Now;
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);
        string second = LeadingZero(time.Second);

        //concatenating the hours, minutes, and seconds with colon separator characters. 
        textClock.text = "Time Now: " + hour + ":" + minute + ":" + second;
	}

    // takes as input an integer and returns a string of this number with leading zeros added to the left, if the value was less than 10
    string LeadingZero(int n) {
        return n.ToString().PadLeft(2,'0');
    }
}

/*Unity tutorial on how to create 3D objects and animate them through script to display an analogue clock 
https://unity3d.com/learn/tutorials/modules/beginner/scripting/simple-clock
 */