using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helm:MonoBehaviour
{
    public int nearZero;

    public void SetThrottle(Slider slider)
    {
        //Zeroes out the throttle if the 
        //Debug.Log("Slider value:" + slider.value);
        if (slider.value < nearZero && slider.value > -nearZero)
        {
            slider.value = 0;
        }
        //Get the new setting and report it to the ship class
        Debug.Log("Throttle value:" + slider.value);
    }

    public void ReleaseWheel(Image image)
    {

    }

    public void TurnWheel(Image image)
    {
        float xAxis = Input.mousePosition.x - image.transform.position.x;
        float yAxis = Input.mousePosition.y - image.transform.position.y;
        Debug.Log(xAxis + " " + yAxis);
    }
}
