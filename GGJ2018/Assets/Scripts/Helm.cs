using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helm:MonoBehaviour
{
    public int nearZero;

    private Vector3 initialMousePos;

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
        image.transform.rotation = Quaternion.identity;
    }

    public void TurnWheel(Image image)
    {
        Vector3 currMousePos = Input.mousePosition;

        float angle = Vector2.Angle(initialMousePos-image.transform.position, currMousePos-image.transform.position);
        //float yAxis = Input.mousePosition.y - initialMousePos.y;
        //Debug.Log(xAxis + " " + yAxis);

        Vector3 rotationVec;

        if (Vector3.Cross(initialMousePos - image.transform.position, currMousePos - image.transform.position).z < 0)
        {
            rotationVec = new Vector3(0F, 0F, -angle);
        }
        else
        {
            rotationVec = new Vector3(0F, 0F, angle);
        }

        image.transform.Rotate(rotationVec);

        initialMousePos = currMousePos;
    }

    public void GrabWheel()
    {
        initialMousePos = Input.mousePosition;
        Debug.Log("Grabbed at " + initialMousePos);

    }
}
