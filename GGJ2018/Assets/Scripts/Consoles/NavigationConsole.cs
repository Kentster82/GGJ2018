using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationConsole : MonoBehaviour {

    public GameObject player;
    public GameObject UIPanel;
    public Camera navCamera;

    public float interactDistance = 2f;
    // Use this for initialization
    void Start ()
    {
        navCamera = GameObject.Find("navCamera").GetComponent<Camera>();
        UIPanel = GameObject.Find("NavigationPanel");
        player = GameObject.Find("Player");
        UIPanel.SetActive(false);
    }

    public void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1) && Vector2.Distance(this.transform.position, player.transform.position) < interactDistance)
        {
            UIPanel.SetActive(true);
            Camera.main.enabled = false;
            navCamera.enabled = true;
        }
    }

    public void ExitConsole()
    {
        UIPanel.SetActive(false);
        navCamera.enabled = false;
        Camera.main.enabled = true;
    }
}
