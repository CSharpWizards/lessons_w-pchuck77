using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLights : MonoBehaviour {
	public Light lightSource;
	public 
	void Lights(){
		Text buttonText = GetComponentInChildren<Text> ();

		if (lightSource.intensity==10) {
			lightSource.intensity = 0;
			buttonText.text = "выключено";
		}
		else {
			lightSource.intensity = 10;
			buttonText.text= "включено";
		}
	}
	// Use this for initialization
	void Start () {
		Button button = GetComponent<Button> ();
		button.onClick.AddListener (Lights);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
