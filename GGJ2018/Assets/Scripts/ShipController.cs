using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    // scalar from -1 to 1 for use with helm
    public float throttle = 0;
    // if health reaches zero, you die
    public float health;
    // take damage before health, regenerate over time
    public float shields;

    //How fast the ship accelerates
    public float thrust = 5f;
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
		
	}
}
