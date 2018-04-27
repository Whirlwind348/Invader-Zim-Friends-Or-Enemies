using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecile : MonoBehaviour {
	public Rigidbody2D projectile;
		public Transform Spawnpoint;
		int D;
	Animator An;

		// Use this for initialization
		void Start () {
		An = gameObject.GetComponent <Animator> ();
		}

		// Update is called once per frame
		void Update () {
		if(Input.GetKeyDown(KeyCode.F)){
			An.SetTrigger ("Shoot");

			}
		}
	void GGGG(){
		Rigidbody2D clone;
		clone = (Rigidbody2D)Instantiate (projectile);
		clone.AddForce (new Vector2 (5, 0), ForceMode2D.Impulse);
	}
}
