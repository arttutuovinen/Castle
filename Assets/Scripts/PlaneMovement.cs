using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float speed = 10f;        // The speed of the plane
    public Vector3 movementDirection = Vector3.forward; // The direction in which the plane moves
    public float rotationSpeed = 5f; // The rotation speed of the plane

    public float heightSpeed = 3f;   // The speed of height change
    public float maxHeight = 8f;    // The maximum height
    public float minHeight = 1f;     // The minimum height
    private bool ascending = true;    // Flag to indicate if the plane is ascending
    private bool isPaused = false;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    void Update()
    {
        // Move the plane forward automatically
        transform.Translate(movementDirection * speed * Time.deltaTime);

        // Rotate the plane left and right based on input
        float horizontalInput = Input.GetAxis("Horizontal"); // A or D keys or arrow keys left and right
        float rotationAmount = rotationSpeed * horizontalInput * Time.deltaTime;
        transform.Rotate(Vector3.up * rotationAmount);

        // Manually control the plane's height using vertical inputs
        float verticalInput = Input.GetAxis("Vertical"); // W or S keys or arrow keys up and down

        if (verticalInput != 0)
        {
            float newY = transform.position.y + verticalInput * heightSpeed * Time.deltaTime;
            newY = Mathf.Clamp(newY, minHeight, maxHeight); //makes sure the plane stays at the needed heights
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
    
        //Pause
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPaused = !isPaused;

            if(isPaused)
            {
                Time.timeScale = 1f;
            }

            else
            {
                Time.timeScale = 0f;
            }
        }

        //Quitting game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}



