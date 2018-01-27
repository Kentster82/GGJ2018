using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private GameObject ship;

    void Awake()
    {
        ship = GameObject.Find("Ship");
        GameObject shield = GameObject.Find("ShieldPanel");
        shield.SetActive(false);
    }

    public void SetShieldOn(bool onOff)
    {
        //Shield in ShipController is set on/off
        ship.GetComponent<ShipController>().shieldActive = onOff;

        //Debug.Log("Shield on: " + onOff);
    }
}
