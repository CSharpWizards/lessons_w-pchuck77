using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			Shoot (true);
		} else if(Input.GetKeyDown(KeyCode.Mouse1)){
			Shoot (false);
		}
	}
	GameObject spawnedBluePortalBall;
	GameObject spawnedRedPortalBall;
	public GameObject BluePortalBall;
	public GameObject RedPortalBall;
	void Shoot(bool isMouse0){
		if (isMouse0) {
			if (spawnedBluePortalBall!=null) {
				Destroy (spawnedBluePortalBall);
			}
			spawnedBluePortalBall=Instantiate (BluePortalBall,transform.position,transform.rotation);
		} else {
			if (spawnedRedPortalBall!=null) {
				Destroy (spawnedRedPortalBall);
			}
			spawnedRedPortalBall=Instantiate (RedPortalBall,transform.position,transform.rotation);
		}

	}
}
