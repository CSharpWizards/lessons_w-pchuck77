using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float time=0;
	// Update is called once per frame
	void Update () {
		Renderer render = GetComponent<Renderer> ();
		time = time + Time.deltaTime;
		if (time<1) {
		render.material.color = Color.red;	
		} 
		else if (time<2) {
			render.material.color = Color.yellow;
		} else if (time<3) {
			render.material.color = Color.green;

		} else {
			time = 0;
		}
	}
}
