using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dist : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	public Transform enemy;
	// Update is called once per frame
	void Update () {

		float dist = Vector3.Distance (enemy.position, transform.position);
		print (dist);
	}
}
	

