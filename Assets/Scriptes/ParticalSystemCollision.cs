using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalSystemCollision : MonoBehaviour
{
private void OnParticleCollision(GameObject other)
    {
        if  (other.CompareTag("Fire"))
        {
            other.GetComponent<ParticleSystem>().Stop();
        }
    }
}
