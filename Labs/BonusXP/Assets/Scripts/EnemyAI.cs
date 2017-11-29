using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
	private Rigidbody2D rb;
	public float speed = 2f;
	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update()
	{


		Vector3 movement = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-4.0f, 4.0f), 0);
		rb.velocity = movement * speed;
	}
}
