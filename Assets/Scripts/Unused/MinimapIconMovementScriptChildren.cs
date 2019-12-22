using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapIconMovementScriptChildren : MonoBehaviour {

    public GameObject minimapObject;
    Vector3 objectPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Transform child in transform)
        {

        }
        objectPosition = new Vector3(minimapObject.transform.position.x, 150, minimapObject.transform.position.z);
        gameObject.transform.position = objectPosition;
	}
}
//Nemogu jer moram imat referencu na što prate, a neda mi se sad tražit pametan način za to