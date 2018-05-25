using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_leverGrab : MonoBehaviour {

    // Initialize the public variables
    public Transform leverTransform;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (!GetComponent<OVRGrabbable>().isGrabbed)
        {
            transform.position = leverTransform.position;
            transform.rotation = leverTransform.rotation;
        }
	}
}
