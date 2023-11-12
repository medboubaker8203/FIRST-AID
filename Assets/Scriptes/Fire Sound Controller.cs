using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSoundController : MonoBehaviour
{
    public Transform player;
    public float maxDistance = 10f;
    public AudioClip fireSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (fireSound != null)
        {
            audioSource.clip = fireSound;
            audioSource.loop = true;
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Fire sound is not assigned to the script.");
        }
    }

    void Update()
    {
        if (player == null)
        {
            Debug.LogError("Player not assigned to the script.");
            return;
        }

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        float normalizedDistance = Mathf.Clamp01(distanceToPlayer / maxDistance);

        // You can use a custom function to map the distance to a volume range that fits your needs
        float volume = MapDistanceToVolume(normalizedDistance);

        audioSource.volume = volume;
    }

    float MapDistanceToVolume(float normalizedDistance)
    {
        // You can customize this function based on how you want the volume to change with distance
        // For example, you can use a logarithmic scale for a more realistic attenuation effect
        return 1f - normalizedDistance; // Simple linear mapping, adjust as needed
    }
}
