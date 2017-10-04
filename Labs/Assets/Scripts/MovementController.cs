﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public float speed = 10.0f;

    private Rigidbody2D rBody;
    //public Transform camTrans;

    // Use this for initialization
    void Start()
    {
        rBody = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizMove = Input.GetAxis("Horizontal");
        //float vertMove = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizMove, 0, 0);
        rBody.velocity = movement * speed;
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if(other.gameObject.tag == Trig1)
    //    {
            
    //    }
    //    if(other.gameObject.tag == Trig2)
    //    {

    //    }
    //}
}
