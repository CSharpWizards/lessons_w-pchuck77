using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		Rigidbody force = GetComponent<Rigidbody> ();
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			force.AddForce(new Vector3(0,200,0));
		}
	}
}
