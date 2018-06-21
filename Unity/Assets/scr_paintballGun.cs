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
		if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch)
		{
			GameObject i = Instantiate(projectile, transform) as GameObject;
			i.GetComponent<RigidBody>().
		}
	}
}
