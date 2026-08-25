using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float flingStrength = 15;// degrees per second
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.attachedRigidbody;
        if (rb == null || rb.isKinematic) return;

        Vector3 pushDirection = (other.transform.position - transform.position).normalized;

        // Add an upward component to give an arc to the fling
        pushDirection += Vector3.up * 0.5f;

        // Only apply impulse on Z and upward (Y) so X movement is preserved
        Vector3 impulse = new Vector3(0f, pushDirection.normalized.y * flingStrength, pushDirection.normalized.z * flingStrength);
        rb.AddForce(impulse, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
