using UnityEngine;
using TMPro;

public class TapNumber : MonoBehaviour
{
    public string phoneNumber; // Assign the respective phone number in the Inspector
    public GameObject phoneScreen; // Assign the phone screen GameObject in the Inspector
    private bool isCalling = false;

    private void Start()
    {
        // Debug log to check if the phoneScreen is assigned
        if (phoneScreen == null)
        {
            Debug.LogError("Phone screen not assigned to " + gameObject.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand") && !isCalling)
        {
            DisplayNumberOnScreen(phoneNumber);
           // CheckAndMakeCall(phoneNumber);
        }
    }

    private void DisplayNumberOnScreen(string number)
    {
        // Debug log to check if phoneScreen is null before accessing its components
        if (phoneScreen != null)
        {
            // Your logic to display the tapped number on the phone screen using TextMeshPro - Text
            TextMeshPro textComponent = phoneScreen.GetComponent<TextMeshPro>();
            if (textComponent != null)
            {
                textComponent.text += number;
            }
            else
            {
                Debug.LogError("TextMeshPro component not found on " + phoneScreen.name);
            }
        }
        else
        {
            Debug.LogError("Phone screen not assigned to " + gameObject.name);
        }
    }

}
