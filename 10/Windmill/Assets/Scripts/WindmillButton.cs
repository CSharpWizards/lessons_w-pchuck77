using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindmillButton : MonoBehaviour {
	bool isOn;
	void StartWindmill(){
		if (isOn==true) {
			isOn = false;
		} else {
			isOn = true;
		}
	}
	// Use this for initialization
	void Start () {
		Button button = GetComponent<Button> ();
		button.onClick.AddListener (StartWindmill);
	}
	public Transform windmillTransform;
	// Update is called once per frame
	void Update () {
		if (isOn==true) {
			windmillTransform.Rotate((new Vector3(0,0,10))*Time.deltaTime);
		}
	}
}
