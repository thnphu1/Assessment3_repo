using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the movement speed as needed.

    void Update()
    {
        // Get input from the player.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement vector based on input.
        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized * moveSpeed;

        // Move the GameObject.
        transform.Translate(movement * Time.deltaTime);
    }
}
