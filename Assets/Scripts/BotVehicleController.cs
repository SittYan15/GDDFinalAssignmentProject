using UnityEngine;

public class BotVehicleController : MonoBehaviour
{
    public float speed = 10.0f; // Speed of the vehicle

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
