using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAudioVolume : MonoBehaviour {

    public AudioSource source;
    

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update()
    {
        float volume = VolumeSlider.getVolumeSliderValue();
        source.volume = volume / 10f;

    }

    private void Awake()
    {
        source.volume = 0.5f;
    }
}
