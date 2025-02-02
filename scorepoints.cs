using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI; // Required for UI components

public class ScorePoints : MonoBehaviour
{
    public static int scoreValue = 0; // Static variable to track the score
    private Text score; // Reference to the UI Text component

    void Start()
    {
        // Get the Text component attached to this GameObject
        score = GetComponent<Text>();

        // Check if the Text component was found

        if (score == null)
        {
            Debug.LogError("No Text component found! Make sure this script is attached to a GameObject with a UI Text component.");
        }
    }

    void Update()
    {
        // Update the score display
        if (score != null)
        {
            score.text = "Score: " + scoreValue;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            // Check if the object collided with is tagged as "Collectible" (e.g., a banana)
            if (collision.CompareTag("Collectible"))
            {
                Debug.Log("Banana collision detected with: " + collision.gameObject.name);

                // Increment the score
                scoreValue += 1;

                // Destroy the collectible (banana)
                Destroy(collision.gameObject);

                // Log the updated score
                Debug.Log("Score Updated: " + scoreValue);
            }
        }
    }
    
}
