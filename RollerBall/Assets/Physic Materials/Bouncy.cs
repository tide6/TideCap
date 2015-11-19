using UnityEngine;
using System.Collections;

public class Bouncy : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision) {
		rb.velocity = new Vector3(0, 8.4f, 0);
	}
}
