using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CannonConfig
{
    public float rotationSpeed, launchSpeed;
    public GameObject cannonBall;
    public Transform shotSpawn;

    //public GameObject[] cannonBall2;
    //public List<GameObject> cannonBall3;
}
public class CannonControll : MonoBehaviour {

    public CannonConfig cannonConfig;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Rotate(Vector3.back * cannonConfig.rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(-Vector3.back * cannonConfig.rotationSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            GameObject Ball = Instantiate(cannonConfig.cannonBall, cannonConfig.shotSpawn.position, Quaternion.identity) as GameObject;
                Vector2 forceVec = cannonConfig.shotSpawn.transform.position = this.transform.position;
            forceVec *= cannonConfig.launchSpeed;

            Ball.GetComponent<Rigidbody2D>().AddForce(forceVec);
        }
    }

}
