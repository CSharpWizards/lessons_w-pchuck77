﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public Transform enemyPos;
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(enemyPos.position,transform.position)>10) {
			print ("Враг близко!");

		}
	}
}