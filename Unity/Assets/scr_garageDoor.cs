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

    // Use this for initialization
    void Start()
    {

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
    }
}
