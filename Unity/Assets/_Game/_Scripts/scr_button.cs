using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_button : MonoBehaviour {

    // Initialize the public variables
    public GameObject buttonStatePressed;
    public GameObject buttonStateReleased;
    public GameObject console;
    public int rendererIndex;

    // Initialize the private variables
    private bool activated;

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            buttonStatePressed.SetActive(true);
            buttonStateReleased.SetActive(false);

            // Check if the corresponding light is lit
            if (console.GetComponent<scr_console>().renderers[rendererIndex].material == console.GetComponent<scr_console>().materialRedLit ||
                console.GetComponent<scr_console>().materialGreenLit || console.GetComponent<scr_console>().materialBlueLit)
            {
                console.GetComponent<scr_console>().materialSet = false;
                console.GetComponent<scr_console>().waitAlarm = console.GetComponent<scr_console>().waitAlarmDuration;
            }
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
