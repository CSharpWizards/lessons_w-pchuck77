using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public Transform[] positions;
	int destination=0;
	// Update is called once per frame
	void Update () {
		if (destination==positions.Length) {
			destination = 0;
		} 
		Vector3 direction = positions[destination].position - transform.position;
		direction.Normalize ();
		transform.Translate (direction*5*Time.deltaTime);
		float distance = Vector3.Distance (transform.position, positions [destination].position);

		if (distance<0.5) {
			destination = destination + 1;
		}
	}
}
