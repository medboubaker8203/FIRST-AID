using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireExtinguisher : MonoBehaviour
{
    public ParticleSystem gasParticleSystem;
    private bool isSpraying = false;
    private XRGrabInteractable xrGrabInteractable;

    private string triggerButtonName = "Fire1"; // Change this to your assigned XR trigger button name

    private void Start()
    {
        xrGrabInteractable = GetComponent<XRGrabInteractable>();
        if (xrGrabInteractable == null)
        {
            Debug.LogError("XR Grab Interactable not found on FireExtinguisher GameObject.");
        }

        // Subscribe to the grab and ungrab events
        xrGrabInteractable.onSelectEnter.AddListener(OnGrab);
        xrGrabInteractable.onSelectExit.AddListener(OnRelease);
    }

    private void Update()
    {
        // Check for input to start/stop spraying gas using XR input and when grabbed
        if (isSpraying)
        {
            EnableEmission();
        }
        else
        {
            DisableEmission();
        }

        if (Input.GetButton(triggerButtonName) && isSpraying)
        {
            StartSpraying();
        }
        else if (isSpraying)
        {
            StopSpraying();
        }
    }

    private void OnGrab(XRBaseInteractor interactor)
    {
        isSpraying = true;
        gasParticleSystem.Play();
        EnableEmission();
    }

    private void OnRelease(XRBaseInteractor interactor)
    {
        isSpraying = false;
        gasParticleSystem.Stop();
        DisableEmission();
    }

    private void StartSpraying()
    {
        var emission = gasParticleSystem.emission;
        emission.enabled = true;
    }

    private void StopSpraying()
    {
        var emission = gasParticleSystem.emission;
        emission.enabled = false;
    }

    // Enable emission of particles
    private void EnableEmission()
    {
        var emission = gasParticleSystem.emission;
        emission.enabled = true;
    }

    // Disable emission of particles
    private void DisableEmission()
    {
        var emission = gasParticleSystem.emission;
        emission.enabled = false;
    }
}
