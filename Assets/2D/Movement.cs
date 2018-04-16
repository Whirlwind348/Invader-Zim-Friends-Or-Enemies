using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	float X;
	float invX;
	float Dir;
	Rigidbody2D Zim;
	// Use this for initialization
	void Start () {
		Zim = gameObject.GetComponent<Rigidbody2D>();
		X = Zim.velocity.x;
		invX = -X;
	}
	
	// Update is called once per frame
	void Update () {
		X = Zim.velocity.x;
		invX = -X;
		Dir = Input.GetAxis ("Horizontal");
	}
	void FixedUpdate(){
		if (Input.GetButton ("Horizontal")) {
			if (Dir > 0) {
				
			}
			if (Dir < 0) {
				Zim.AddForce (new Vector2 (0.1f, 0), ForceMode2D.Impulse);
			}
		}
		if (Input.GetKeyUp ("Horizontal")) {
			Zim.AddForce (new Vector2 (invX, 0), ForceMode2D.Impulse);
		}
	}
}
