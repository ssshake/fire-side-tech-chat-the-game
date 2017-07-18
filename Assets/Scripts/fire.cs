using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fire : MonoBehaviour {
	public GameObject explosion;
	public GameObject blood;
	public GameObject playerController;
	public bool bloodEnabled = false;

    void OnTriggerEnter(Collider other) {
		GameObject explosionInstance = GameObject.Instantiate (explosion);
		explosionInstance.transform.position = other.gameObject.transform.position;

		if (bloodEnabled) {
			GameObject bloodInstance = GameObject.Instantiate (blood);
			bloodInstance.transform.position = other.gameObject.transform.position;
		}

		playerController.SendMessage ("PlayerSaved");
		other.gameObject.GetComponent<Collider> ().enabled = false;
		Destroy(other.gameObject, .05f);
	}
}
