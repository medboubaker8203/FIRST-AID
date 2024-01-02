using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandTrackingCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.HandTracking, devices);
        if (devices.Count > 0)
        {
            Debug.Log("Hand tracking is enabled");
        }
        else
        {
            Debug.Log("Hand tracking is not enabled");
        }
    }
}
