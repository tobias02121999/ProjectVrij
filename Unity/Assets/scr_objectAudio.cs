using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_objectAudio : MonoBehaviour {

    // Initialize the public variables
    public AudioSource audioSource;
    public AudioClip grabAudio;
    public AudioClip collideAudio;

    // Initialize the private variables
    private bool playedSound;

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
		if (GetComponent<OVRGrabbable>().isGrabbed && !playedSound)
        {
            audioSource.clip = grabAudio;
            audioSource.Play();
            playedSound = true;
        }

        if (!GetComponent<OVRGrabbable>().isGrabbed)
        {
            playedSound = false;
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        audioSource.clip = collideAudio;
        audioSource.Play();
    }
}
