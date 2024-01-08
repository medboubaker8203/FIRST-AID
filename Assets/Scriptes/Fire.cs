using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is the gas particle
        if (other.CompareTag("Gas"))
        {
            ExtinguishFire();
        }
    }

    private void ExtinguishFire()
    {
        // Put logic here to extinguish the fire (e.g., disable the fire effect)
        gameObject.SetActive(false); // For example, deactivate the fire GameObject
    }
}
