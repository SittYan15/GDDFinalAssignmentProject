using UnityEngine;
using UnityEngine.InputSystem;

public class P1PlayerController : MonoBehaviour
{
    private float speed = 10.0f; // Speed of the vehicle
    private float turnSpeed = 35.0f; // Speed of the vehicle's turning
    private float horizontalInput; // Input for horizontal movement
    private float verticalInput; // Input for vertical movement

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // We'll turn the vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

    // This function is called when a move input is detected
    void OnMove(InputValue movementValue)
    {
        // Function body for handling player movement input for Vector2
        Vector2 movementVector = movementValue.Get<Vector2>();

        // Snap input to -1, 0, or 1 for each axis
        horizontalInput = Mathf.Round(movementVector.x);
        verticalInput = Mathf.Round(movementVector.y);
    }
}
