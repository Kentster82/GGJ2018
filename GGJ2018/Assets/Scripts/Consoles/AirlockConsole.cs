using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirlockConsole : MonoBehaviour
{
    public GameObject player;
    public GameObject UIPanel;

    public float interactDistance = 2f;
    // Use this for initialization
    void Awake()
    {
        UIPanel = GameObject.Find("AirlockPanel");
        player = GameObject.Find("Player");

        UIPanel.SetActive(false);
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1) && Vector2.Distance(this.transform.position, player.transform.position) < interactDistance)
        {
            UIPanel.SetActive(true);
        }
    }

    public void ExitConsole()
    {
        UIPanel.SetActive(false);
    }
}
