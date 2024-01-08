using UnityEngine;
using Oculus;

public class HandTrackingCheck : MonoBehaviour
{
    public OVRHand leftHand;
    public OVRHand rightHand;

    void Update()
    {
        if (leftHand.enabled || rightHand.enabled)
        {
            Debug.Log("Hand tracking is working");
        }
        else
        {
            Debug.Log("Hand tracking is not working");
        }
    }
}