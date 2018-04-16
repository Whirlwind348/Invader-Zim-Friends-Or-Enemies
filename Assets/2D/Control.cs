using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
	public Animator Mov;
	int Dir;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Horizontal")) {
			Mov.SetTrigger ("Right");
		}
		if (Input.GetButtonUp ("Horizontal")) {
			Mov.SetTrigger ("Idle");
		}
	}
	void LateUpdate(){
		if (Input.GetButtonDown ("Run")) {
				Mov.SetTrigger ("Run Right");
			
		}
		if (Input.GetButtonUp ("Run")) {
			Mov.SetTrigger ("Right");
		}
	}
}

