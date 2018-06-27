using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_startOfficeScene : MonoBehaviour {

    // Initialize the public variables
    public GameObject weaponTable;
    public GameObject waypointPath1;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey("1"))
        {
            weaponTable.SetActive(true);
        }

        if (Input.GetKey("2"))
        {
            waypointPath1.SetActive(true);
        }
	}
}
