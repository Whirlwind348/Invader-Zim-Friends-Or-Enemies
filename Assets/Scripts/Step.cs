using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour {
	public AudioClip StepAud;
	public AudioSource Stepper;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Stepping(){
		Stepper.PlayOneShot (StepAud);
	}
}
