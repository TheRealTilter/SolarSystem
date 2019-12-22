using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour {

    public static float volumeSliderValue;
    public Slider volumeSlider;

	// Use this for initialization
	void Start () {
        //volumeSliderValue = 5;
	}
	
	// Update is called once per frame
	void Update() {
        volumeSliderValue = volumeSlider.value;
	}

    static public float getVolumeSliderValue()
    {
        return volumeSliderValue;
    }


}
