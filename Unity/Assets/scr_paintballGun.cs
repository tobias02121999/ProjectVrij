using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_paintballGun : MonoBehaviour {

	// Initialize the public variables
	public GameObject projectile;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch) >= .25 || Input.GetMouseButton(0))
		{
			Instantiate(projectile, transform.position, transform.rotation);
		}
	}
}
