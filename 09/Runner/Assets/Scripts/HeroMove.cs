using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour {
	
	void OnTriggerEnter (Collider other){
		if (other.tag=="Obstacle") {
			Destroy (gameObject);

		}

	}
	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody speed = GetComponent<Rigidbody> ();
		speed.velocity=new Vector3(10,speed.velocity.y,0);

	}
}
