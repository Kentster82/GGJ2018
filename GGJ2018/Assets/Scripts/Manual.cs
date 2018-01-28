using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manual : MonoBehaviour
{
    GameObject manual;

    public void Awake()
    {
        manual = GameObject.Find("ManualPanel");
    }

    public void Start()
    {
        manual.SetActive(false);
    }
    public void changePage(GameObject page)
    {
        GameObject taggedObj = GameObject.FindGameObjectWithTag("page");
        if(taggedObj != null)
        {
            taggedObj.SetActive(false);
        }
        page.SetActive(true);
    }	
}
