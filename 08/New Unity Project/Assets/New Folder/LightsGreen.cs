using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsGreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float time=0;
	// Update is called once per frame
	void Update () {
		Renderer render = GetComponent<Renderer> ();
		time = time + Time.deltaTime;
		if (time<3 && time>2) {
			render.material.color = Color.green;	
		}
		else if (time>3) {
			time = 0;
		} else {
			render.material.color = Color.gray;
		}
	}
}
