using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    // Use this for initialization
    public float speed;
    Vector3 mousePos;
    Camera c;
	void Start () {
        mousePos = new Vector3();
        c = Camera.main;
        speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
          mousePos = c.ScreenToWorldPoint(Input.mousePosition);
          transform.LookAt(mousePos);
          transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, transform.localEulerAngles.z);

          if (Input.GetMouseButton(0))
          {
              transform.position += (-transform.position + mousePos).normalized * speed * Time.deltaTime;
              transform.position = new Vector3(transform.position.x, 0, transform.position.z);
          }
    }

    void FixedUpdate()
    {

    }
}
