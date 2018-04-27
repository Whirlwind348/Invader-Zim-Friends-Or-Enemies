using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour
{
	BoxCollider2D Coll;
	GameObject Self;
	Animator Project;

	// Use this for initialization
	void Start ()
	{
		Coll = gameObject.GetComponent <BoxCollider2D>();
		Self = gameObject.GetComponent <GameObject> ();
		Project = gameObject.GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Enemy"){
			Debug.Log("Damage");
		}
		else {
			Project.Play("Hit");
		}
	}
	void Boom(){
		Destroy (this.gameObject);
	}
			
}

