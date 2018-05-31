using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_pathFinder : MonoBehaviour {

    // Initialize the public variables
    public Transform[] waypointTransforms;
    public int[] waypointAlarms;
    public AudioSource[] waypointAudioPlayers;
    public float movementSpeed;
    public float rotationSpeed;

    // Initialize the private variables
    private int currentWaypoint;
    private int alarm;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 targetDirection = waypointTransforms[currentWaypoint].position - transform.position;

        if (currentWaypoint <= waypointTransforms.Length - 1)
        {
            if (transform.position != waypointTransforms[currentWaypoint].position)
            {
                transform.position = Vector3.MoveTowards(transform.position, waypointTransforms[currentWaypoint].position, movementSpeed);
                transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(transform.forward, targetDirection, rotationSpeed, 0f));
                alarm = waypointAlarms[currentWaypoint];
            }
            else
            {
                if (alarm <= 0)
                {
                    currentWaypoint++;
                }
            }
        }

        alarm--;
	}
}
