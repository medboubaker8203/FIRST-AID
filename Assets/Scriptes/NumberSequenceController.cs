using System.Collections.Generic;
using UnityEngine;

public class NumberSequenceController : MonoBehaviour
{
    private List<string> numberSequence; // To store the sequence of tapped numbers
    private int sequenceIndex; // To keep track of the current position in the sequence

    public List<GameObject> numberObjects; // Assign all number GameObjects in the Inspector
    public GameObject numberObject;

    public void Start()
    {
        numberSequence = new List<string>();
        sequenceIndex = 0;

        HideAllNumbers(); // Hide all numbers initially
    }

    // Function to check the entered sequence against the correct code (198)
    public bool AddToSequence(string numberTag)
    {
        string[] correctCode = { "Number1", "Number9", "Number8" };

        if (sequenceIndex < correctCode.Length && numberTag == correctCode[sequenceIndex])
        {
            numberSequence.Add(numberTag);
            Debug.Log(numberTag);
            numberObject.SetActive(true);
            sequenceIndex++;

            if (sequenceIndex == correctCode.Length)
            {
                Debug.Log("Correct sequence entered!"); // The correct sequence (198) has been entered
                return true;
            }
        }
        else
        {
            Debug.Log("Incorrect sequence!");
            ResetSequence(); // Reset the sequence if incorrect
        }

        return false;
    }

    // Function to reset the sequence and sequence index
    private void ResetSequence()
    {
        numberSequence.Clear();
        sequenceIndex = 0;
    }

    // Function to hide all number GameObjects
    public void HideAllNumbers()
    {
        foreach (GameObject numberObject in numberObjects)
        {
            numberObject.SetActive(false);
        }
    }
}
