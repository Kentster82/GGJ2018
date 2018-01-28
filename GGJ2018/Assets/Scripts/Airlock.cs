using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airlock : MonoBehaviour
{
    public GameObject airlock;

    public void Awake()
    {
        airlock = GameObject.Find("AirlockPanel");
    }

    public void Start()
    {
        airlock.SetActive(false);
    }

    public void OpenAirlock()
    {
        Debug.Log("Airlock opened.");
        //Report to shipController.  Will check if ship is close enough to planet
        //Sound Effects?
    }	
}
