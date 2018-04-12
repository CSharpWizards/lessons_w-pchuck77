using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marshal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public Transform[] objects;
	// Update is called once per frame
	void Update () {
		int finished = 0;
		for (int i = 0; i < objects.Length; i++) {
			if (objects[i].position.y>0) {
				finished = 1;
			}
			 
		}
		if (finished==0) {
			print ("все финишировали");
		}
	}
}
