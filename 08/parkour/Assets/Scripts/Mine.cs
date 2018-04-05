using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public Transform playerTransform;
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(playerTransform.position,transform.position)<2) {
			playerTransform.position = new Vector3 (0, 2, -10);
			print (21344);
		}
	}
}
