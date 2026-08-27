using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(Vector3.up, 90 * Time.deltaTime);
    }
}