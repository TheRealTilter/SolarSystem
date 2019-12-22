using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyBetweenScenes : MonoBehaviour {

    private static DontDestroyBetweenScenes instance = null;
    public static DontDestroyBetweenScenes Instance
    {
        get { return instance; }
    }
	
	void Awake () {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
	}
}
