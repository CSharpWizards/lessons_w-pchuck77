using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {
	
	void OnTriggerEnter(Collider other){
		if (RedPortalBall.spawnedPortal == null || BluePortalBall.spawnedPortal == null||timer>0) {
			return;
		}
		if (other.tag=="BluePortal"){
			transform.position = RedPortalBall.spawnedPortal.transform.position;
			timer = 1;
	    }	
		if (other.tag=="RedPortal"){
			transform.position = BluePortalBall.spawnedPortal.transform.position;
			timer=1;
		}
	}


	void Start () {
		
	}
	double timer=0;
	// Update is called once per frame
	void Update () {
		timer = timer - Time.deltaTime;
	}
}
