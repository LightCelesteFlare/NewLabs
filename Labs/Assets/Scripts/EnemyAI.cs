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


		Vector3 movement = new Vector3(Random.Range(-1.0f * Time.deltaTime, 1.0f * Time.deltaTime), Random.Range(-1.0f * Time.deltaTime, 1.0f * Time.deltaTime), 0);
		rb.velocity = movement * speed;
	}
}
