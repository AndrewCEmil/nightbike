using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private float speed;
	private Vector3 direction;
	// Use this for initialization
	void Start () {
		speed = 1.0f;
		direction = new Vector3 (1, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = gameObject.transform.position + speed * direction;
	}


	void OnTriggerEnter(Collider other) {
		Debug.Log ("TRIGGERED");
	}
}
