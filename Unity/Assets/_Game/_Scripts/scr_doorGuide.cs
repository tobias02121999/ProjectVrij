using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_doorGuide : MonoBehaviour {

    // Initialize the public variables
    public GameObject[] targetPathObject;
    public float doorOpenSpeed;
    public float doorCloseSpeed;
    public float doorOpenRange;
    public float doorCloseAlarmDuration;
    public float currentYRotation = 180;
    public int[] waypointTriggerId;

    // Initialize the private variables
    private float doorCloseAlarm;
    private bool isOpened;
    private int currentWaypointTriggerId;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (targetPathObject[currentWaypointTriggerId].GetComponent<scr_pathFinder>().currentWaypoint > waypointTriggerId[currentWaypointTriggerId] && !isOpened)
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
                currentWaypointTriggerId++;
                isOpened = false;
            }
        }

        doorCloseAlarm--;

        transform.rotation = Quaternion.Euler(0f, currentYRotation, 0f);
    }
}
