using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour {
	static int score=0;

	void OnTriggerEnter(Collider other){
		if (other.tag=="Bullet") {
			
			score = score + 1;
			textCaption.text = score.ToString();
			Destroy (gameObject);
			Destroy (other.gameObject);

		}
	}
	Text textCaption;
	// Use this for initialization
	void Start () {
		GameObject text=GameObject.Find("Text");
		textCaption = text.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
			
	}
}
