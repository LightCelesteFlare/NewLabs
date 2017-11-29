using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
	private Rigidbody2D rb;
	public float speed = 2f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		float horizMove = Input.GetAxis("Horizontal");
		float vertMove = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(horizMove, vertMove, 0);
		rb.velocity = movement * speed;
	}
}
