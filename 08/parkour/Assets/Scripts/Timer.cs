using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float time=0;
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;
		if (time>15) {
			transform.position = new Vector3 (0, 0, -10);
		} else {
			time = 0;
		}
	}
}
