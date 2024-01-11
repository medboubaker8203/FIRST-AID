using UnityEngine;
using TMPro;

public class CallButton : MonoBehaviour
{
    public GameObject phoneScreen; // Assign the phone screen GameObject in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            MakeCall();
        }
    }

    private void MakeCall()
    {
        // Get the content displayed on the phone screen
        string phoneNumber = phoneScreen.GetComponent<TextMeshPro>().text;

        // Pass the content to the function that checks and makes the call
        CheckAndMakeCall(phoneNumber);
    }

    private void CheckAndMakeCall(string number)
    {
        if (number == "198")
        {
            Debug.Log("You called Himeya!");
            // Add your logic for what happens when 198 is called
        }
        else
        {
            Debug.Log("Jarreb marra okhraa yee houssem!");
            // Add your logic for what happens when a number other than 198 is called
        }

        // Reset the phone screen after the call
        phoneScreen.GetComponent<TextMeshPro>().text = "";
    }
}
