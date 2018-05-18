using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_blinkLight : MonoBehaviour {

    // Initialize the public variables
    public float alarmDurationOff;
    public float alarmDurationOn;
    public Light _light;

    // Initialize the private variables
    private float alarm;
    private bool isOn;

	// Use this for initialization
	void Start () 
    {
        alarm = alarmDurationOff;
	}
	
	// Update is called once per frame
	void Update () 
    {
        alarm--;

        if (alarm <= 0f)
        {
            if (isOn)
            {
                isOn = false;
                alarm = alarmDurationOff;
            }
            else
            {
                isOn = true;
                alarm = alarmDurationOn;
            }
        }

        _light.enabled = isOn;
	}
}
