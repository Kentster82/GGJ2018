using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineering : MonoBehaviour
{
    private GameObject ship;
    private GameObject eng;

    public void Awake()
    {
        ship = GameObject.Find("Ship");
        eng = GameObject.Find("EngineeringPanel");
    }
    public void Start()
    {
        eng.SetActive(false);
    }

    public void ReverseRepairStatus(int button)
    {
        switch(button)
        {
            case 0:
                ship.GetComponent<ShipController>().helmStationActive = !ship.GetComponent<ShipController>().helmStationActive;
                break;
            case 1:
                ship.GetComponent<ShipController>().navStationActive = !ship.GetComponent<ShipController>().navStationActive;
                break;
            case 2:
                ship.GetComponent<ShipController>().airlockStationActive = !ship.GetComponent<ShipController>().airlockStationActive;
                break;
            case 3:
                ship.GetComponent<ShipController>().manualStationActive = !ship.GetComponent<ShipController>().manualStationActive;
                break;
            case 4:
                ship.GetComponent<ShipController>().shieldStationActive = !ship.GetComponent<ShipController>().shieldStationActive;
                break;
            default:
                break;
        }
    }
}
