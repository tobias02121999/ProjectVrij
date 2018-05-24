using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_shrek : MonoBehaviour {

    // Initialize the public variables
    public float movementSpeed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += transform.forward * movementSpeed;
	}
}
