using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helm:MonoBehaviour
{
    public int nearZero;
    public int wheelNearZero;

    private Vector3 initialMousePos;
    private Text speedometer;

    public void Awake()
    {
        speedometer = GameObject.Find("Speedometer").GetComponent<Text>();
    }

    public void SetThrottle(Slider slider)
    {
        //Zeroes out the throttle if it was set near zero
        if (slider.value < nearZero && slider.value > -nearZero)
        {
            slider.value = 0;
        }

        //Get the new setting and report it to ShipController
        //ShipControllerobject.throttle = slider.value / 10;

        SetSpeedometer(Mathf.RoundToInt(Mathf.Abs(slider.value) * 10));
    }

    public void ReleaseWheel(Image image)
    {
        //Snaps the wheel to center if it's close enough to zero
        if (image.transform.rotation.eulerAngles.z < wheelNearZero || image.transform.rotation.eulerAngles.z > 360-wheelNearZero)
        {
            image.transform.rotation = Quaternion.identity;
            //Get the new setting and report it to ShipController
            //shipTransform.rotation = Quaternion.identity;
        }
    }

    public void TurnWheel(Image image)
    {
        Vector3 currMousePos = Input.mousePosition;

        float angle = Vector2.Angle(initialMousePos-image.transform.position, currMousePos-image.transform.position);

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
        //Get the new setting and report it to ShipController
        //shipTransform.rotation = rotationVec???

        initialMousePos = currMousePos;
    }

    public void GrabWheel()
    {
        initialMousePos = Input.mousePosition;
    }

    public void SetSpeedometer(int speed)
    {
        speedometer.text = speed.ToString();
    }
}
