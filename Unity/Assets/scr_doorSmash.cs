using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_doorSmash : MonoBehaviour {

    // Initialize the public variables
    public GameObject angryRobot;
    public float rotateSpeed;
    public float rotateMin;
    public float rotateMax;

    // Initialize the private variables
    private bool rotateUp;
    private float currentRotationX = 90f;

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (1 == 1)
        {
            if (rotateUp)
            {
                if (currentRotationX <= (90f + rotateMax) - rotateSpeed)
                {
                    currentRotationX += rotateSpeed;
                }
                else
                {
                    currentRotationX = rotateMax + 90f;
                    rotateUp = false;
                }
            } else
            {
                if (currentRotationX >= (90f - rotateMin) + rotateSpeed)
                {
                    currentRotationX -= rotateSpeed;
                }
                else
                {
                    currentRotationX = rotateMin;
                    rotateUp = true;
                }
            }
        }

        transform.rotation = Quaternion.Euler(currentRotationX, 90f, 0f);
	}
}
