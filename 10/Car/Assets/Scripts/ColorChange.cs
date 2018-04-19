using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour {
	public Material carMaterial;
	public Color carColor;
	void ColorChange(){
		carMaterial.color = carColor;
	}
	// Use this for initialization
	void Start () {
		Button button = GetComponent<Button> ();
		button.onClick.AddListener (ColorChange);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
