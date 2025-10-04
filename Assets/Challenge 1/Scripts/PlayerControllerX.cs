using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    public GameObject propeller;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        // rotate the propeller
        propeller.transform.Rotate(Vector3.forward * 1000 * Time.deltaTime);
    }

    void OnMove(InputValue movementValue)
    {
        // Function body for handling player movement input for Vector2
        Vector2 movementVector = movementValue.Get<Vector2>();

        // Snap input to -1, 0, or 1 for each axis
        //horizontalInput = Mathf.Round(movementVector.x);
        verticalInput = Mathf.Round(movementVector.y);
    }
}
