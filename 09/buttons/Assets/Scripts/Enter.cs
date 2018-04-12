using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour {
	public Text text;
	void Enterr(){
		if (int.Parse(text.text)<16) {
			print ("выход");
			Application.Quit();
		} else {
			SceneManager.LoadScene ("level1");
		}
	}
	// Use this for initialization
	void Start () {
		Button button = GetComponent<Button> ();
		button.onClick.AddListener (Enterr);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
