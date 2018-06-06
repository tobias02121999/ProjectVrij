using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_room0 : MonoBehaviour {

    // Initialize the public variables
    public GameObject garagePlane;
    public float garageOpenTimerDuration;

    // Initialize the private variables
    private float garageOpenTimer;

	// Use this for initialization
	void Start ()
    {
        garageOpenTimer = garageOpenTimerDuration;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (garageOpenTimer <= 0f)
        {
            garagePlane.GetComponent<scr_garageDoor>().forceOpen = true;
        }

        garageOpenTimer--;
	}
}
