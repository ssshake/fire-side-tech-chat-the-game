using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speech : MonoBehaviour {
	public GameObject bubble;
	public GameObject text;
	public string[] phrases;
	bool textShown = false;
	public int speechDelay = 2000;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.Range (0, speechDelay) < 10) {
			SetRandomText ();
		}
	}

	void SetRandomText(){
		if (textShown) {
			return;
		}
		textShown = true;
		bubble.SetActive (true);
		text.GetComponent<Text> ().text = phrases [Random.Range (0, phrases.Length)];
		Invoke ("HideText", 3f);
	}

	void HideText(){
		textShown = false;
		bubble.SetActive (false);
	}
}
