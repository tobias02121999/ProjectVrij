using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_leverGrab : MonoBehaviour {

    // Initialize the public variables
    public Transform leverTransform;

    // Initialize the private variables
    private float startPositionY;

	// Use this for initialization
	void Start ()
    {
        startPositionY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (!GetComponent<OVRGrabbable>().isGrabbed)
        {
            transform.position = new Vector3(leverTransform.position.x, startPositionY, leverTransform.position.z);
            transform.rotation = leverTransform.rotation;
        }
	}
}
