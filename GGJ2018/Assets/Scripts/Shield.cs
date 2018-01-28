using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private GameObject ship;
    private GameObject shield;

    void Awake()
    {
        ship = GameObject.Find("Ship");
        shield = GameObject.Find("ShieldPanel");
        
    }

    private void Start()
    {
        shield.SetActive(false);
    }

    public void SetShieldOn(bool onOff)
    {
        //Shield in ShipController is set on/off
        ship.GetComponent<ShipController>().shieldActive = onOff;

        //Debug.Log("Shield on: " + onOff);
    }
}
