using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;

	void Update() {
		Instantiate (object, transform.position, transform.rotation);
	}

	void Start () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * speed;
	}

}
