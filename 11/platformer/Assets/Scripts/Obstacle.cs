using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	
	void OnTriggerEnter(Collider other){
		if (other.tag =="obstacle") {
			transform.position = new Vector3 (0, 2, -8);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
