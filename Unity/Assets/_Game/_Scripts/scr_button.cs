using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_button : MonoBehaviour {

    // Initialize the public variables
    public GameObject buttonStatePressed;
    public GameObject buttonStateReleased;

    // Initialize the private variables
    private bool activated;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (activated)
        {
            buttonStatePressed.SetActive(true);
            buttonStateReleased.SetActive(false);
        }
        else
        {
            buttonStatePressed.SetActive(false);
            buttonStateReleased.SetActive(true);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            activated = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hands")
        {
            activated = false;
        }
    }
}
