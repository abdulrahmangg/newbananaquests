using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3; // Set initial number of lives

    void Update()
    {
        // Check if lives reach 0, and handle game over
        if (lives <= 0)
        {
            Debug.Log("Game Over!");
            // Optionally, reload the scene or show a game-over screen
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene");
        }
    }

    public void LoseLife()
    {
        lives--; // Reduce one life
        Debug.Log("Lives left: " + lives);
    }
}

