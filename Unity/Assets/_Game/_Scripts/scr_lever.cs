using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_lever : MonoBehaviour {

    // Initialize the public variables
    public GameObject grabObject;
    public Transform grabTransform;
    public float pullDistanceMin;
    public float pullDistanceMax;

    // Initialize the private variables
    private float transformStartX;

	// Use this for initialization
	void Start ()
    {
        transformStartX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (grabObject.GetComponent<OVRGrabbable>().isGrabbed)
        {
            transform.position = new Vector3(Mathf.Clamp(grabTransform.position.x, transformStartX - pullDistanceMax, transformStartX - pullDistanceMin), transform.position.y, transform.position.z);
        }
	}
}
