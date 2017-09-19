using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	Rigidbody rb;
	bool canJump = true;
	public float jumpForce = 700f;
	public float moveForce = 2000f;

	public float maxVelocity = 5f;

	private Vector3 startPosition;
	private Vector3 respawnPosition;

	void Start () {

		rb = GetComponent<Rigidbody>();
		startPosition = respawnPosition = transform.position;

	}

	void Update () {

		var x = 0f;
		if (rb.velocity.x > (maxVelocity * -1) && rb.velocity.x < maxVelocity) {
			x = Input.GetAxis ("Horizontal") * Time.deltaTime * moveForce;
		}

		var z = 0f;
		if (rb.velocity.z > (maxVelocity * -1) && rb.velocity.z < maxVelocity) {
			z = Input.GetAxis ("Vertical") * Time.deltaTime * moveForce;
		}

		rb.AddForce (new Vector3(x, 0, z), ForceMode.Acceleration);

		if (Input.GetKey ("space") && canJump && rb.velocity.y <= maxVelocity) {
			canJump = false;
			rb.AddForce (new Vector3(0, jumpForce, 0), ForceMode.Acceleration);
		}

		if (transform.position.y < 0) {
			transform.position = respawnPosition;
		}
	}
		
	void OnCollisionEnter(Collision coll) 
	{
		if (coll.gameObject.tag == "Ground" && rb.velocity.y < 1) {
			canJump = true;
		}

		if (coll.gameObject.name == "Teleport1") {
			transform.position = respawnPosition = new Vector3(82.0f,26.0f,82.0f);

		}

		if (coll.gameObject.name == "Teleport2") {
			transform.position = respawnPosition = startPosition;
		}
	}
}
