using UnityEngine;
using System.Collections;

public class Done_Mover : MonoBehaviour
{
	public float speed;

	private IEnumerator waitToDieCoroutine;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed;

		print ("Starting wait to die coroutine " + Time.time);
		waitToDieCoroutine = WaitToDie (15.0f);
		StartCoroutine (waitToDieCoroutine);
	}

	public IEnumerator WaitToDie(float waitTime) {
		yield return new WaitForSeconds (waitTime);
		Destroy (gameObject);
	}
}
