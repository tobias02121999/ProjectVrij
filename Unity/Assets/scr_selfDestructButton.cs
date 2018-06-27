using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_selfDestructButton : MonoBehaviour {

    // Initialize the public variables
    public GameObject endActivationObject;
    public float alarmDuration;
    public GameObject buttonActivateDoor;
    public AudioSource audioSource;
    public AudioSource audioSourceWheelchair;
    public GameObject wheelchairPathPoint;

    // Initialize the private variables
    public float alarm;
    public bool isActivated;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isActivated)
            alarm--;

        if (isActivated && alarm < 0f)
        {
            endActivationObject.SetActive(true);
            buttonActivateDoor.GetComponent<scr_shrek>().shrekkerinoEnabled = true;
            audioSourceWheelchair.enabled = false;
            wheelchairPathPoint.SetActive(true);
        }
    }

    // Check for collision with hands
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands" && !isActivated)
        {
            alarm = alarmDuration;
            audioSource.Play();
            isActivated = true;
        }
    }
}
