using UnityEngine;
using UnityEngine.InputSystem;

public class Chud : MonoBehaviour
{
    // movement speed in units per second
    public float jumpVelocity = 6f;
    public float groundCheckDistance = 1.1f;
    public float moveSpeed = 5f;
    public int maxJumps = 2;
    Rigidbody rb;
    int jumpCount = 0;

    void Awake()
    { 
        rb = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool IsGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);
        // All the movement code for now
        if (Keyboard.current != null && Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Keyboard.current != null && Keyboard.current.aKey.isPressed)
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Keyboard.current != null && Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Keyboard.current != null && Keyboard.current.dKey.isPressed)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame && (IsGrounded || jumpCount < maxJumps))
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpVelocity, rb.linearVelocity.z);
            jumpCount++;
        }
        else if (IsGrounded)
        {
            jumpCount = 0;
        }
    }
}
