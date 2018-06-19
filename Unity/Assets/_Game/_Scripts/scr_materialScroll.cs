using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_materialScroll : MonoBehaviour {

    // Initialize the public variables
    public float scrollX;
    public float scrollY;
    public Renderer materialRenderer;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float offsetX = Time.time * scrollX;
        float offsetY = Time.time * scrollY;

        materialRenderer.material.mainTextureOffset = new Vector2(offsetX, offsetY);
	}
}
