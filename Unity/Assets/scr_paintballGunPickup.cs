using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_paintballGunPickup : MonoBehaviour {

    // Initialize the public variables
    public GameObject paintballGun;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    // Check for hand collision
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            paintballGun.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
