using UnityEngine;

public class NumberTap : MonoBehaviour
{
    public string numberTag; // Assign the respective number tag ("Number1", "Number9", "Number8") in the Inspector
    //public GameObject numberObject; // Assign the corresponding number GameObject for this script in the Inspector
    private NumberSequenceController sequenceController;

    private void Start()
    {
        sequenceController = FindObjectOfType<NumberSequenceController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand")) // Assuming the player's hand has a specific tag
        {
            if (!string.IsNullOrEmpty(numberTag))
            {
                bool isCorrectSequence = sequenceController.AddToSequence(numberTag); // Add the tapped number to the sequence controller

                if (isCorrectSequence)
                {
                    // Activate the corresponding number GameObject if the sequence is correct
                    //numberObject.SetActive(true);
                }
                else
                {
                    // Hide all numbers if the sequence is incorrect
                    sequenceController.HideAllNumbers();
                }
            }
            else
            {
                Debug.LogError("Number tag is not assigned!");
            }
        }
    }
}
