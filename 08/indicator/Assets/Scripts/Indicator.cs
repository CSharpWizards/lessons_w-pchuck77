using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public Transform playerPosition;
	// Update is called once per frame
	void Update () {
		Renderer render = GetComponent<Renderer> ();
		float distance = Vector3.Distance (playerPosition.position, transform.position);
		if (distance<10) {
			render.material.color = new Color (distance / 10,0,0);
		
		} else {
			render.material.color = Color.red;
		}	
	}
}
