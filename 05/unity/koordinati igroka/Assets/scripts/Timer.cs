using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	float time=0;
	void Update () {
		time = time + Time.deltaTime ;
		int second = (int)time;
		print("количество секунд: "+second);
	}
}
