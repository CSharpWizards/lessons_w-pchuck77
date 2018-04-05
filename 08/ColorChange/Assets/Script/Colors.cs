using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float time=0;
	// Update is called once per frame
	void Update () {
		Renderer render = GetComponent<Renderer> ();
		time = time + Time.deltaTime;
		if (time>1) {
			time = 0;
		}
		render.material.color = new Color (1, time, time);
	}
}
