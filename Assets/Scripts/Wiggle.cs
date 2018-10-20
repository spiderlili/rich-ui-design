using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour {
    public bool wiggle = true;
    public float speed = 10.0f;
    Vector2 origin; 
    float timeBetween; //time between each wiggle movement - related to speed
    public float offset = 2.0f; //how far away it goes

	// Use this for initialization
	void Start () {
        origin = transform.position;
        wiggle = true;
        speed = 10.0f;
        offset = 2.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (wiggle == true) {
            //increment timeBetween as time goes on
            //calculate the next position to go to - 1f/speed gives the desired duration speed in the end, otherwise it's too quick
            if (timeBetween > 1f / speed) 
            {
                float toX = Random.Range(-2.0f, +2.0f);
                float toY = Random.Range(-2.0f, +2.0f);
                //add origin to the random numbers
                transform.position = new Vector2(origin.x + toX, origin.y + toY);
                timeBetween = 0f; //make sure time starts incrementing again from this

                //if too far away from the original position, set it back to where it started, otherwise it would be going off the screen
                if (transform.position.x + offset < origin.x && transform.position.x - offset > origin.x && transform.position.y + offset < origin.y && transform.position.y - offset > origin.y)
                {
                    transform.position = origin;
                }
            }
            else
            {
                timeBetween += Time.deltaTime; //time between increment
            }
        }
        else
        {
            transform.position = origin; //don't move at all if wiggle is unchecked
        }
    }
}
