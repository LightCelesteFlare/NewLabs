using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestory : MonoBehaviour {
	
	// Update is called once per frame
	void FixedUpdate () {
        Destroy(gameObject, 1.05f);
	}
}
