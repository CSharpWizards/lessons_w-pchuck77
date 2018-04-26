using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float time=0;
	int wave=1;
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;

		if (time>3) {
			
			print (wave);
			wave=wave+1;
			time = 0;
		}
	}
}
