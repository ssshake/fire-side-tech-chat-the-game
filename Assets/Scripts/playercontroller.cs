using UnityEngine;
using System.Collections;

public class playercontroller : MonoBehaviour {

	public float Speed = 1f;
	public float rotSpeed = 1f;
	public float jumpForce = 10f;

	private float movex = 0f;
	private float movez = 0f;

	bool grounded = true;

	void FixedUpdate () {
		movex = Input.GetAxis ("Horizontal");
		movez = Input.GetAxis ("Vertical");

		transform.Translate(0, 0, movez * Speed * Time.deltaTime);
		transform.Rotate (0, movex * rotSpeed, 0);

		if (Input.GetButtonDown("Jump") && grounded) {
			grounded = false;
			GetComponent<Rigidbody> ().velocity = new Vector3(0,jumpForce,0);
		}
	}

	void OnCollisionStay()
	{
		grounded = true;
	}
}