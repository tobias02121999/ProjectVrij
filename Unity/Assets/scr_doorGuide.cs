using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_doorGuide : MonoBehaviour {

    // Initialize the public variables
    public GameObject guide;
    public float doorOpenSpeed;
    public float doorOpenRange;
    public int waypointTriggerId;

    // Initialize the private variables
    private float currentYRotation = 180;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (guide.GetComponent<scr_pathFinder>().currentWaypoint > waypointTriggerId)
        {
            if (doorOpenRange > currentYRotation + doorOpenSpeed)
            {
                currentYRotation += doorOpenSpeed;
            }

            if (doorOpenRange < currentYRotation - doorOpenSpeed)
            {
                currentYRotation -= doorOpenSpeed;
            }
        }

        transform.rotation = Quaternion.Euler(0f, currentYRotation, 0f);
	}
}
