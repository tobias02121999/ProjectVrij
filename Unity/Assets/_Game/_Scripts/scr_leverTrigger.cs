using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_leverTrigger : MonoBehaviour {

    // Initialize the public variables
    public bool isUp;
    public GameObject garageDoor;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    // When colliding with an object
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Lever")
        {
            if (isUp)
            {
                garageDoor.GetComponent<scr_garageDoor>().isMovingUp = true;
            }
            else
            {
                garageDoor.GetComponent<scr_garageDoor>().isMovingDown = true;
            }
        }
    }

    // When collision with an object ends
    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Lever")
        {
            if (isUp)
            {
                garageDoor.GetComponent<scr_garageDoor>().isMovingUp = false;
            }
            else
            {
                garageDoor.GetComponent<scr_garageDoor>().isMovingDown = false;
            }
        }
    }
}
