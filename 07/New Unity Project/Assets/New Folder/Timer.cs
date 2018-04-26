using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float time=20;
	// Update is called once per frame
	void Update () {
		time = time - Time.deltaTime;
		if (time<0) {
			print ("время вышло");
		}
		else {
			print ((int)time);
		}
	}
}
