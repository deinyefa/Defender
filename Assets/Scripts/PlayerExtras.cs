using UnityEngine;
using System.Collections;

public class PlayerExtras : MonoBehaviour {

	public Done_GameController gameController;

	private GameObject mainCamera;
	private GameObject engine;

	void Start () {
		engine = GameObject.FindGameObjectWithTag ("Engine");
		mainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
	}

	void Update () {
		CameraFollow ();
	}

	/// <summary>
	/// Follows the camera.
	/// </summary>
	void CameraFollow () {
		if (mainCamera == null) {
			Debug.Log ("cannot find MainCamera tag. pls add a tag to it.");
		} else {
			mainCamera.transform.position = new Vector3 (0, 42f, this.transform.position.z + -36.7f);
		}
	}

	/// <summary>
	/// Checks when this GameObject has collided with something else
	/// </summary>
	void OnTriggerEnter (Collider other) {
		Debug.Log (other.gameObject.name + " has collided with me");

		if (other.gameObject.tag == "Obstacle" || other.gameObject.tag == "Enemy") {
			gameController.gameOver = true;
			GetComponent <MeshRenderer> ().enabled = false;
			engine.SetActive (false);
		}
	}
}
