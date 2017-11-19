using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMessages : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World!");
        Debug.LogWarning("This is a warning message.");
        Debug.LogError("This is a error message.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
