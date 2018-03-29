using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maxvisota : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	int visota;
	// Update is called once per frame
	void Update () {
		if (visota<transform.position.y) {
			visota = (int)transform.position.y;
		}
		print(visota);
	}
}
