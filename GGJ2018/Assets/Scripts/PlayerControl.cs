using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    // Use this for initialization
    public float speed = 0;
    Vector3 mousePos;
    Camera c;
    public bool is_valid;

	Animator anim;

	void Start () {
        mousePos = new Vector3();
        c = Camera.main;
        is_valid = true;

		anim = transform.Find ("Sprites").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
        if (is_valid)
        {
            mousePos = c.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -c.transform.position.z));
            transform.LookAt(mousePos);
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0);

            if (Input.GetMouseButton(0))
            {
                transform.position += (-transform.position + mousePos).normalized * speed * Time.deltaTime;
                transform.position = new Vector3(transform.position.x, transform.position.y, 0);
				anim.SetBool ("Flappin", true);
			} else {
				anim.SetBool("Flappin", false);
			}
        }
    }

    void FixedUpdate()
    {

    }
}
