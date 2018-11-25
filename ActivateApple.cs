using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateApple : MonoBehaviour {

    public GameObject objectToEnable;
    public static bool disabled = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (disabled)
            objectToEnable.SetActive(true);
	}
}
