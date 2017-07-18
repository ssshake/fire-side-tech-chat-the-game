using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class setName : MonoBehaviour {
	public Text nameText;

	void Start(){
		nameText.GetComponent<Text> ().text = gameObject.name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
