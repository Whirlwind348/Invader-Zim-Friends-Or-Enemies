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
		if (Dir == 0) {
			if (Input.GetButtonDown ("Horizontal")) {
				Dir = 1;
				Mov.SetTrigger ("Right");
			}
		}
		if (Dir == 1) {
			if (Input.GetButtonUp ("Horizontal")) {
				Dir = 0;
				Mov.SetTrigger ("Idle");
			}
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

