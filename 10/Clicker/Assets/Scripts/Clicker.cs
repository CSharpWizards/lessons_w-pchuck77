using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clicker : MonoBehaviour {
	public Text timer;
	public Text counter;
	float time = 4;
	void Click (){
		if (time>0) {
			counter.text=(int.Parse(counter.text)+1).ToString();

		}
	}
	// Use this for initialization
	void Start () {
		Button button = GetComponent<Button> ();
		button.onClick.AddListener (Click);

	}
	
	// Update is called once per frame
	void Update () {
		time = time - Time.deltaTime;
		if (time>0) {
			timer.text = ((int)time).ToString ();
		} else {
			if (int.Parse(counter.text)>15) {
				SceneManager.LoadScene ("Win");
			} else {
				SceneManager.LoadScene ("Lose");
			}

		}
	}
}
