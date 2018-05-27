using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_webcamMaterial : MonoBehaviour {

    // Initialize the public variables
    public Material material;

	// Use this for initialization
	void Start ()
    {
        WebCamTexture webcamTexture = new WebCamTexture();
        material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
