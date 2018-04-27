using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFunctions : MonoBehaviour {
	public Animator Con;
	int Count;
	public AudioSource Laugh;
	public AudioClip LA;

	// Use this for initialization
	void Start () {
		Count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void CountUp()
	{
		Count = Count + 1;
		if (Count == 5){
			Con.SetTrigger("LaughEnd");
		}
	}
	void LoopStart()
	{
		Con.SetTrigger ("LoopLA");
	}
	void LaughStart()
	{
		Laugh.PlayOneShot (LA);
	}
}
