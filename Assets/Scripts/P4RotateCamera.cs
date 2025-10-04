using UnityEngine;
using UnityEngine.InputSystem;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;

    // Movement along X and Y axes.
    private float movementX;
    private float movementY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, movementX * rotationSpeed * Time.deltaTime, Space.World);
    }

    // This function is called when a move input is detected
    void OnMove(InputValue movementValue)
    {
        // Function body for handling player movement input for Vector2
        Vector2 movementVector = movementValue.Get<Vector2>();

        // Store the X and Y components of the movement vector
        movementX = Mathf.Round(movementVector.x);
        movementY = Mathf.Round(movementVector.y);
    }
}
