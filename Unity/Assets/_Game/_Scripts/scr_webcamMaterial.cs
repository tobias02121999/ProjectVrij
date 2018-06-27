using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_webcamMaterial : MonoBehaviour {

    // Initialize the public variables
    public Material targetMaterial;

	// Use this for initialization
	void Start ()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        WebCamTexture webcamTexture = new WebCamTexture();

        webcamTexture.deviceName = devices[1].name;
        targetMaterial.mainTexture = webcamTexture;
        webcamTexture.Play();

        Debug.Log(devices[1].name);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
