using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_projectile : MonoBehaviour {

    // Initialize the public variables
    public float thrust;
    public Rigidbody rb;
    public GameObject paintSplat;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * thrust);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    // Check for collision
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PaintSurface")
        {
            GameObject i = Instantiate(paintSplat, transform.position, new Quaternion(0f, transform.localEulerAngles.y, 0f, 0f)) as GameObject;
            i.transform.SetParent(null);
        }
    }
}
