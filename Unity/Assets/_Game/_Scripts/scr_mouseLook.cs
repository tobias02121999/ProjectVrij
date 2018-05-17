using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_mouseLook : MonoBehaviour {

    // Initialize the public variables
    public float mouseSensitivityX;
    public float mouseSensitivityY;

    // Initialize the private variables
    private float rotationX;
    private float rotationY;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        rotationX -= Input.GetAxis("Mouse Y") * mouseSensitivityY;
        rotationY += Input.GetAxis("Mouse X") * mouseSensitivityX;

        transform.rotation = Quaternion.Euler(rotationX, rotationY, transform.eulerAngles.z);
	}
}
