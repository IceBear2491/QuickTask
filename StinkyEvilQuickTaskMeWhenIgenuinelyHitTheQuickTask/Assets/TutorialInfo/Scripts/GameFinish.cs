using UnityEngine;

public class GameFinish : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.attachedRigidbody;
        if (rb == null || rb.isKinematic) return;

        // your logic here, e.g. finish the game
        Debug.Log("Game is Over");
    }
}
