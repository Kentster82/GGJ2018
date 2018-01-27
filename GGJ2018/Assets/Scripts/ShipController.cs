﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    // scalar from -1 to 1 for use with helm
    public float throttle = 0;
    // if hull integrity reaches zero, you die
    public float hull;
    // How much damage the shield will absorb on impact;
    public float shieldAbsorb;

    // Whether or not these stations are currently disabled
    public bool helmStationActive;
    public bool navStationActive;
    public bool statusStationActive;
    public bool airlockStationActive;
    public bool manualStationActive;
    public bool eBrakeStationActive;
    public bool shieldStationActive;

    // Whether or not the ship's shield is currently active
    public bool shieldActive;

    //How fast the ship accelerates
    public float thrust = 0.1f;
    //public reference to ship's transform
    public Transform shipTransform;

    private Rigidbody2D rb;
    
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        shipTransform = this.transform;
	}

    void FixedUpdate()
    {
        rb.AddForce(transform.up * thrust * throttle);
    }

    void Update ()
    {
        // dummy code for testing eBrake
	    if(Input.GetButton("Jump"))
        {
            StartCoroutine("eBrake");
        }

        // dummy code for testing steering
        shipTransform.Rotate(0, 0, -Input.GetAxis("Horizontal"));

        //dummy code for testing throttle
        throttle = Input.GetAxis("Vertical");
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("asteroid"))
        {
            damage(collision.rigidbody.mass);
        }
    }

    void damage(float damage)
    {
        if(shieldActive)
        {
            hull -= (damage - shieldAbsorb);
        }
        else
        {
            hull -= damage;
        }
        if(hull <= 0)
        {
            Debug.Log("Ded");
            // Some game over stuff
        }
    }

    IEnumerator eBrake()
    {
        throttle = 0f;
        while(rb.velocity.x > 0 || rb.velocity.y > 0)
        {
            if(rb.velocity.x < 0.0005f && rb.velocity.x > 0f)
            {
                rb.velocity = new Vector2(0f, rb.velocity.y);
            }
            if (rb.velocity.y < 0.0005f && rb.velocity.y > 0f)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0f);
            }
            rb.drag += 0.001f;
            yield return null;
        }
        rb.drag = 0f;
    }
}
