using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_lever : MonoBehaviour {

    // Initialize the public variables
    public Transform grabTransform;
    public float pullDistanceMin;
    public float pullDistanceMax;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(Mathf.Clamp(grabTransform.position.x, pullDistanceMin, pullDistanceMax), transform.position.y, transform.position.z);
	}
}
