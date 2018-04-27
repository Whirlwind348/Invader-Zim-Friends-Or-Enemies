using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Default : MonoBehaviour {
	public Animator Def;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		
	}
	void SetState ()
	{
		Def.SetTrigger ("Idle");
	}
}
