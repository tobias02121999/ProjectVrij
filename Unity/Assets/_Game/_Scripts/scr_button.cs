﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_button : MonoBehaviour {

    // Initialize the public variables
    public GameObject buttonStatePressed;
    public GameObject buttonStateReleased;
    public GameObject console;
    public Renderer screenRenderer;
    public Material screenMaterialRight;
    public Material screenMaterialWrong;
    public Material materialGreenLit;
    public int rendererIndex;

    // Initialize the private variables
    private bool activated;

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        Debug.Log(console.GetComponent<scr_console>().renderers[rendererIndex].material);

        if (activated)
        {
            buttonStatePressed.SetActive(true);
            buttonStateReleased.SetActive(false);

            // Check if the corresponding light is lit
            if (console.GetComponent<scr_console>().waitAlarm <= 0f)
            {
                switch (rendererIndex)
                {
                    case 0:
                        if (console.GetComponent<scr_console>().redIsLit)
                        {
                            screenRenderer.material = screenMaterialRight;
                        }
                        else
                        {
                            screenRenderer.material = screenMaterialWrong;
                        }
                        break;

                    case 1:
                        if (console.GetComponent<scr_console>().greenIsLit)
                        {
                            screenRenderer.material = screenMaterialRight;
                        }
                        else
                        {
                            screenRenderer.material = screenMaterialWrong;
                        }
                        break;

                    case 2:
                        if (console.GetComponent<scr_console>().blueIsLit)
                        {
                            screenRenderer.material = screenMaterialRight;
                        }
                        else
                        {
                            screenRenderer.material = screenMaterialWrong;
                        }
                        break;
                }
            }

            console.GetComponent<scr_console>().materialSet = false;
            console.GetComponent<scr_console>().waitAlarm = console.GetComponent<scr_console>().waitAlarmDuration;
        }
        else
        {
            buttonStatePressed.SetActive(false);
            buttonStateReleased.SetActive(true);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            activated = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hands")
        {
            activated = false;
        }
    }
}
