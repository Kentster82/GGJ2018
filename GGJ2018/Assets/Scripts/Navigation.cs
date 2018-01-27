using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour {

    public BoxCollider2D navConsole;
    
    public Camera navCamera;

	// Use this for initialization
	void Start ()
    {
        navConsole = GetComponent<BoxCollider2D>();
        navCamera = GameObject.Find("navCamera").GetComponent<Camera>();
    
	}

    public void EnterConsole()
    {
        Camera.main.enabled = false;
        navCamera.enabled = true;
    }

    public void ExitConsole()
    {
        navCamera.enabled = false;
        Camera.main.enabled = true;
    }
}
