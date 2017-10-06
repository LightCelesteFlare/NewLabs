using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
   
    public GameObject bomb;
    public float ExposionRadius = 5.0f;
    public float Exposionforce = 10.0f;
    public float upforce = 0f;
	// Use this for initialization
	void Awake() {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (bomb == enabled)
        {
            Invoke("Detonate", 5);
        }
	}

    void Detonate()
    {
        Vector3 explosionPosition = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, ExposionRadius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(Exposionforce, explosionPosition, ExposionRadius, upforce, ForceMode.Impulse);
            }

        }
    }
}
