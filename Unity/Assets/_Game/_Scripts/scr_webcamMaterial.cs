using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_webcamMaterial : MonoBehaviour {

    // Initialize the public variables
    public Material targetMaterial;

	// Use this for initialization
	void Start ()
    {
        WebCamTexture webcamTexture = new WebCamTexture();
        targetMaterial.mainTexture = webcamTexture;
        webcamTexture.Play();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
