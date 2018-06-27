using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_projectile : MonoBehaviour {

    // Initialize the public variables
    public float thrust;
    public Rigidbody rb;
    public GameObject paintSplat;
    public float destroyAlarmDuration;

    // Initialize the private variables
    private float destroyAlarm;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * thrust);
        destroyAlarm = destroyAlarmDuration;
    }
	
	// Update is called once per frame
	void Update ()
    {
        destroyAlarm--;

        if (destroyAlarm <= 0f)
        {
            Destroy(this.gameObject);
        }
	}

    // Check for collision
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PaintSurface")
        {
            Instantiate(paintSplat, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
