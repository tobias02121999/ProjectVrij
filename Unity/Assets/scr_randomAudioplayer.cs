using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_randomAudioplayer : MonoBehaviour {

    // Initialize the public variables
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public float silentDurationMin;
    public float silentDurationMax;

    // Initialize the private variables
    public float silentAlarm;

	// Use this for initialization
	void Start ()
    {
        silentAlarm = Random.Range(silentDurationMin, silentDurationMax);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (silentAlarm <= 0f)
        {
            audioSource.clip = audioClips[Mathf.RoundToInt(Random.Range(0f, audioClips.Length - 1f))];
            audioSource.Play();
            silentAlarm = Random.Range(silentDurationMin, silentDurationMax);
        }

        silentAlarm--;
	}
}
