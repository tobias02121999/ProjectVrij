using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_doorGuide : MonoBehaviour {

    // Initialize the public variables
    public GameObject guide;
    public float doorOpenSpeed;
    public float doorCloseSpeed;
    public float doorOpenRange;
    public float doorCloseAlarmDuration;
    public float currentYRotation = 180;
    public int waypointTriggerId;
    public Component script;

    // Initialize the private variables
    private float doorCloseAlarm;
    private bool isOpened;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (guide != null)
        {
            if (guide.GetComponent<scr_pathFinder>().currentWaypoint > waypointTriggerId && !isOpened)
            {
                if (doorOpenRange > currentYRotation + doorOpenSpeed)
                {
                    currentYRotation += doorOpenSpeed;
                }

                if (doorOpenRange < currentYRotation - doorOpenSpeed)
                {
                    currentYRotation -= doorOpenSpeed;
                }

                if (!(doorOpenRange > currentYRotation + doorOpenSpeed) && !(doorOpenRange < currentYRotation - doorOpenSpeed))
                {
                    isOpened = true;
                    doorCloseAlarm = doorCloseAlarmDuration;
                }
            }

            if (doorCloseAlarm <= 0f && isOpened)
            {
                if (currentYRotation < 180 - doorCloseSpeed)
                {
                    currentYRotation += doorCloseSpeed;
                }

                if (currentYRotation > 180 + doorCloseSpeed)
                {
                    currentYRotation -= doorCloseSpeed;
                }

                if (!(currentYRotation < 180 - doorCloseSpeed) && !(currentYRotation > 180 + doorCloseSpeed))
                {
                    GetComponent<scr_doorGuide>().enabled = false;
                }
            }

            doorCloseAlarm--;

            transform.rotation = Quaternion.Euler(0f, currentYRotation, 0f);
        }
	}
}
