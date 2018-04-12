using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plus : MonoBehaviour {
	
	public Text text;
	void Pluss (){
		text.text = (int.Parse (text.text) + 1).ToString ();

	}
	// Use this for initialization
	void Start () {	
		Button button = GetComponent<Button> ();
		button.onClick.AddListener (Pluss);
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
}
