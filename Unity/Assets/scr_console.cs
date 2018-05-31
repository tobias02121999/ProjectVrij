using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_console : MonoBehaviour {

    // Initialize the public variables
    public Renderer[] renderers;
    public float waitAlarmDuration;
    public Material materialRed;
    public Material materialRedLit;
    public Material materialGreen;
    public Material materialGreenLit;
    public Material materialBlue;
    public Material materialBlueLit;

    [HideInInspector]
    public bool materialSet;

    [HideInInspector]
    public float waitAlarm;

    // Initialize the private variables
    private int randomIndex;
    
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (waitAlarm <= 0f && !materialSet)
        {
            randomIndex = Mathf.RoundToInt(Random.Range(0f, 2f));
            
            for (int i = 0; i <= 2; i++)
            {
                if (i == randomIndex)
                {
                    switch (i)
                    {
                        case 0:
                            renderers[i].material = materialRedLit;
                            break;

                        case 1:
                            renderers[i].material = materialGreenLit;
                            break;

                        case 2:
                            renderers[i].material = materialBlueLit;
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            renderers[i].material = materialRed;
                            break;

                        case 1:
                            renderers[i].material = materialGreen;
                            break;

                        case 2:
                            renderers[i].material = materialBlue;
                            break;
                    }
                }
            }

            materialSet = true;
        }

        if (waitAlarm > 0f)
        {
            // Reset the lights
            renderers[0].material = materialRed;
            renderers[1].material = materialGreen;
            renderers[2].material = materialBlue;
        }

        waitAlarm--;
	}
}
