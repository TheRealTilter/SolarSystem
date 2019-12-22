using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageDropdownCameras : MonoBehaviour {

    public Vector3[] planetCameraOffset;
    public GameObject[] planets;
    public Dropdown dropdown;
    public Camera[] cameras;
    
	// Use this for initialization
	void Start () {
        cameras[1].enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (cameras[1].enabled == true)
        {
            CameraUpdate(dropdown.value);
        }
    }

    public void Dropdown_IndexChanged(int index) {
        if (index == 0) {
            ReactivateTrails();
        }
        ChooseCamera();
        CameraUpdate(dropdown.value);
        ReactivateTrails();
    }

    void ReactivateTrails()
    {
        for (int i = 0; i < planets.Length; i++)
        {
            planets[i].transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    void CameraUpdate(int dropdownValue) {
        int planetValue = dropdownValue - 1;
        GameObject planet = planets[planetValue];
        planet.transform.GetChild(0).gameObject.SetActive(false);
        cameras[1].transform.position = planet.transform.position + planetCameraOffset[planetValue];
    }

    void ChooseCamera() {
        int dropdownChoice = dropdown.value;
        if (dropdownChoice == 0)
        {
            cameras[0].enabled = true;
            cameras[1].enabled = false;
        }
        else
        {
            cameras[0].enabled = false;
            cameras[1].enabled = true;
        }
    }
}
