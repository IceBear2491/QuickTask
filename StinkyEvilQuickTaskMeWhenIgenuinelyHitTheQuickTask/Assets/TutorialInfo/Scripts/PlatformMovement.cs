using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float plaformSpeed = 1.0f;
    public float movementRange = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * plaformSpeed);
    }
}
