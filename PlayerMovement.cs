using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerMovement : MonoBehaviour
{
    public static int score = 0; // Static score variable
    [Header("Movement Settings")]
    [SerializeField] private float speed = 8f; // Movement speed
    private float horizontal; // Horizontal input
    private float vertical;   // Vertical input

    [Header("Physics Components")]
    [SerializeField] private Rigidbody2D rb; // Reference to Rigidbody2D

    private bool isFacingRight = true; // Tracks the sprite's facing direction

    void Update()
    {
        // Capture player input for movement
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        // Flip the character sprite if needed
        Flip();
    }

    private void FixedUpdate()
    {
        // Apply movement in both horizontal and vertical directions
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }

    private void Flip()
    {
        // Flip the character sprite based on horizontal movement
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object is tagged as "Banana"
        if (collision.CompareTag("Banana"))
        {
            // Increment the score
            score += 10;

            // Destroy the banana object
            Destroy(collision.gameObject);

            // Optional: Debug message
            Debug.Log("Banana collected! Score: " + score);
        }
    }
}
