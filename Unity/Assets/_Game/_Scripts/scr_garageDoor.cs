using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_garageDoor : MonoBehaviour {

    // Initialize the public variables
    public bool isMovingUp;
    public bool isMovingDown;
    public bool forceOpen;
    public float doorOpenSpeed;
    public float doorMinHeight;
    public float doorMaxHeight;
    public GameObject angryRobots;
    public Light coldRoomLight;
    public Light hotRoomLight;
    public Light furnaceLight;

    // Initialize the private variables
    private float coldRoomLightIntensity;
    private float hotRoomLightIntensity;
    private float furnaceLightIntensity;

    // Use this for initialization
    void Start()
    {
        coldRoomLightIntensity = coldRoomLight.intensity;
        hotRoomLightIntensity = hotRoomLight.intensity;
        furnaceLightIntensity = furnaceLight.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        if ((isMovingUp || forceOpen) && transform.position.y <= doorMaxHeight - doorOpenSpeed)
        {
            transform.position += transform.up * doorOpenSpeed;
        }

        if (isMovingDown && transform.position.y >= doorMinHeight + doorOpenSpeed && !forceOpen)
        {
            transform.position -= transform.up * doorOpenSpeed;
        }

        if (transform.position.y >= doorMaxHeight / 2f)
        {
            angryRobots.SetActive(true);
        }

        coldRoomLight.intensity = coldRoomLightIntensity - (transform.position.y - doorMinHeight);
        hotRoomLight.intensity = (transform.position.y - doorMinHeight) * hotRoomLightIntensity;
        furnaceLight.intensity = (transform.position.y - doorMinHeight) * furnaceLightIntensity;
    }
}
