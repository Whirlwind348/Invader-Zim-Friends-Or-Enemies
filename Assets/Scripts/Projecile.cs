using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecile : MonoBehaviour {
	public Rigidbody2D projectile;
		public Transform Spawnpoint;
		int D;

		// Use this for initialization
		void Start () {
		}

		// Update is called once per frame
		void Update () {
			if(Input.GetButtonDown("Fire1")){
			Rigidbody2D clone;
			clone = (Rigidbody2D)Instantiate(projectile);

			clone.AddForce(new Vector2(5, 0), ForceMode2D.Impulse);
			}
		}
	}
