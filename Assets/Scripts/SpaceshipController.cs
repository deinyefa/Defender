using UnityEngine;
using System.Collections;

public class SpaceshipController : MonoBehaviour {

	public Done_GameController gameController;

	public float moveSpeed = 10f;

	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	void FixedUpdate () {
		rb.MovePosition (transform.position + Vector3.forward * moveSpeed * Time.deltaTime);
	}

	void OnTriggerEnter (Collider other) {
		Debug.Log (other.gameObject.name + " has collided with me");

		if (other.gameObject.tag == "Obstacle" || other.gameObject.tag == "Enemy") {
			gameController.gameOver = true;
		}
	}
}
