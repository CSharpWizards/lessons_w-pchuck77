using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour {
	public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	float timer=3;
	// Update is called once per frame
	void Update () {
		Quaternion rotation = Quaternion.Euler (0, 90, 0);

		Vector3 position = new Vector3 (Random.Range (-20, 20), 3, Random.Range (15, 20));
		if (timer<0) {
			Instantiate (target, position,rotation);
			timer = 3;
		}
		timer = timer - Time.deltaTime;
	}
}
