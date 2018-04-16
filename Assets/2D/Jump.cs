using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	float Y;
	Animator Sprite;
	Rigidbody2D Physic;
	bool inAir;
	bool Enabled;
	bool Falling;

	// Use this for initialization
	void Start () {
		Enabled = true;		
		Sprite = gameObject.GetComponent<Animator>();
		Physic = gameObject.GetComponent<Rigidbody2D>();
	}


	// Update is called once per frame
	void Update(){
		Y = Physic.velocity.y;
		Sprite.SetFloat("Y Vel", Y);
		if (Y < 0 && inAir == true && Falling == false) {
			Falling = true;
		}
	}
	void LateUpdate(){
		if (Y == 0 && inAir == true && Falling == true) {
			Sprite.SetTrigger ("Land");
			inAir = false;
			Falling = false;
			Enabled = true;
		}
	}
void FixedUpdate()
		{
		if(Input.GetKeyDown(KeyCode.Space) && Enabled == true){
			Enabled = false;
			Sprite.SetTrigger ("Jump");
			Physic.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
			inAir = true;
			}
 		

		}
		
}
