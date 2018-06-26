using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_randomizePaintSplat : MonoBehaviour {

    // Initialize the public variables
    public SpriteRenderer spriteRenderer;
    public Sprite[] paintSplatterSprites;

	// Use this for initialization
	void Start ()
    {
        spriteRenderer.sprite = paintSplatterSprites[Random.Range(0, 6)];
        spriteRenderer.color = Random.ColorHSV();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
