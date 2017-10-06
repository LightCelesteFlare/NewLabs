using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public GameObject explosion;
    public GameObject bomb;

    public float explosionRate = 1.0f;
    public float explosionforce = 25.0f;
    public float explosion_max_size = 10f;
    public float explodeDelay = 1.9f;
    public float currentRadius = 0f;
    
    CircleCollider2D explosionRadius;


    bool exploded = false;
    // Use this for initialization
    void Awake() {
       explosionRadius  = gameObject.GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        explodeDelay -= Time.deltaTime;
        if (explodeDelay < 0)
        {
            exploded = true;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 explosionPosition = bomb.transform.position;
        if (explodeDelay <= 0)
        {
            if (currentRadius < explosion_max_size)
            {
                currentRadius += explosionRate;
            }
            else
            {
                Instantiate(explosion, explosionPosition, Quaternion.identity);
                Object.Destroy(gameObject);
            }

            explosionRadius.radius = currentRadius;
        }
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector3 explosionPosition = bomb.transform.position;
        Vector3 target = other.gameObject.transform.position;
        

        if (exploded == true)
        {
            if(other.gameObject.GetComponent<Rigidbody2D>() != null)
            {
                Vector3 direction = explosionforce * (target - explosionPosition);

                other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(direction.x / 2f, direction.y * 10f));
            }
        }
    }

}
