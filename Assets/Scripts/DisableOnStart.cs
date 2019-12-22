using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnStart : MonoBehaviour {

    bool once = false;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        //Ovo radim da mi se jednom inicijaliziraju sve skripte pogotovo u Volume jer ako se ne inicijalizira mi audio system dobija VolumeSlider = 0;
        if (!once) {
            this.gameObject.SetActive(false);
            once = true;
        }
	}
}
