using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePortalBall : MonoBehaviour {
	public GameObject Portal;
	public static GameObject spawnedPortal;
	void OnCollisionEnter(Collision other){
		if (other.collider.tag == "Gun") {
			return;
		}
		if (other.collider.tag == "Active") {
			if (spawnedPortal != null) {
				Destroy (spawnedPortal);
			}
			spawnedPortal = Instantiate (Portal, transform.position, Quaternion.FromToRotation (Vector3.forward, other.contacts [0].normal));	
		}
			Destroy(gameObject);
		
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
