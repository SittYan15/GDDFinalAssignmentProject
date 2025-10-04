using UnityEngine;
using UnityEngine.InputSystem;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public Vector3[] cameraOffsets = { new Vector3(0, 5, -9), new Vector3(0, 2, 1) };
    private int currentOffsetIndex = 0;

    private InputAction switchCameraAction;

    void Awake()
    {
        // Create an InputAction for the 'v' key
        switchCameraAction = new InputAction(type: InputActionType.Button, binding: "<Keyboard>/v");
        switchCameraAction.performed += ctx => SwitchCameraOffset();
    }

    void OnEnable()
    {
        switchCameraAction.Enable();
    }

    void OnDisable()
    {
        switchCameraAction.Disable();
    }

    void SwitchCameraOffset()
    {
        currentOffsetIndex = (currentOffsetIndex + 1) % cameraOffsets.Length;
    }

    void LateUpdate()
    {
        // Update camera position
        if (currentOffsetIndex == 1)
        {
            // Offset and rotate with the player
            transform.position = player.transform.TransformPoint(cameraOffsets[currentOffsetIndex]);
            transform.rotation = player.transform.rotation;
        }
        else
        {
            // Default offset, no rotation
            transform.position = player.transform.position + cameraOffsets[currentOffsetIndex];
            transform.rotation = Quaternion.identity;
        }
    }
}