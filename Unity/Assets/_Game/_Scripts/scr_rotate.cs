using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_rotate : MonoBehaviour {

    // Initialize the public variables
    public float rotateSpeed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0f, 0f, rotateSpeed);
	}
}
