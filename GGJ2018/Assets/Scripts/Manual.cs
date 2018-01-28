using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manual : MonoBehaviour
{
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
