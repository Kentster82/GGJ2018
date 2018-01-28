using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyBrake : MonoBehaviour
{
    public GameObject brakePanel;

    public void Awake()
    {
        brakePanel = GameObject.Find("eBrakePanel");
    }
    public void Start()
    {
        brakePanel.SetActive(false);
    }

    public void Brake()
    {
        Debug.Log("Brake.");
        //Report to shipController.  Will brake???
        //Sound Effects?
    }
}
