using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minus : MonoBehaviour {
	public Text text;
	void Minuss(){
		
		text.text = (int.Parse (text.text) - 1).ToString ();
	}

	// Use this for initialization
	void Start () {
		Button button = GetComponent<Button> ();
		button.onClick.AddListener (Minuss);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
