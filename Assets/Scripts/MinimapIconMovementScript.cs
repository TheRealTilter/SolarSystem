using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapIconMovementScript : MonoBehaviour {

    public GameObject minimapObject;
    Vector3 objectPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        objectPosition = new Vector3(minimapObject.transform.position.x, 150, minimapObject.transform.position.z);
        gameObject.transform.position = objectPosition;
	}
}