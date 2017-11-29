using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	private void OnTriggerEnter2D(Collider2D coll)
	{
		{
			Destroy(player);
		}
	}
}
