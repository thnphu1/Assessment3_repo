using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    private Vector2 currentDirection = Vector2.zero; // Pac-Man starts with no movement
    private bool isDead = false;

    private void Update()
    {
        if (!isDead)
        {
            HandleInput();
            Move();
        }
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Rotate Pac-Man 90 degrees to the left and set the direction
            transform.rotation = Quaternion.Euler(0, 0, 90);
            currentDirection = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            // Rotate Pac-Man 90 degrees to the right and set the direction
            transform.rotation = Quaternion.Euler(0, 0, -90);
            currentDirection = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            // Rotate Pac-Man upwards and set the direction
            transform.rotation = Quaternion.Euler(0, 0, 0);
            currentDirection = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            // Rotate Pac-Man 180 degrees downwards and set the direction
            transform.rotation = Quaternion.Euler(0, 0, 180);
            currentDirection = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            // Pac-Man "dies" (disappears) when you press the spacebar
            isDead = true;
            gameObject.SetActive(false); // Hide Pac-Man
        }
    }

    private void Move()
    {
        // Move Pac-Man in the current direction
        Vector2 newPosition = (Vector2)transform.position + currentDirection * moveSpeed * Time.deltaTime;
        transform.position = newPosition;
    }
}
