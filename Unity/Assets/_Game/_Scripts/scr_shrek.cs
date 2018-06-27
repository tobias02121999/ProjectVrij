using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_shrek : MonoBehaviour {

    // Initialize the public variables
    public float movementSpeed;
    public bool shrekkerinoEnabled;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (shrekkerinoEnabled)
            transform.position += transform.up * movementSpeed;
	}
}
