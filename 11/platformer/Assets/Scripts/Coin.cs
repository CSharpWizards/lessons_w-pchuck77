using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour {
	static int score;
	void OnTriggerEnter(Collider other){
		if (other.tag=="Coin") {
			score = score + 1;
			textCaption.text = score.ToString ();
			Destroy (other.gameObject);

		}
	}
	Text textCaption;
	// Use this for initialization
	void Start () {
		GameObject text = GameObject.Find ("Text");
		textCaption = text.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (score==9) {
			SceneManager.LoadScene ("Level2");
		}
	}
}
