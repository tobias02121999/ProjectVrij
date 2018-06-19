using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_wheelchair : MonoBehaviour {

    // Initialize the public variables
    public GameObject guide;
    public GameObject guideWheelchairModel;
    public int waypointModelTrigger;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (guide.GetComponent<scr_pathFinder>().currentWaypoint > waypointModelTrigger)
        {
            GetComponent<scr_pathFinder>().enabled = true;
            guideWheelchairModel.SetActive(true);
            Destroy(guide.gameObject);
        }
	}
}
