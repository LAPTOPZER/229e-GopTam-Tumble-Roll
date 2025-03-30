using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    public float rotationSpeed = 30f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float targetAngularVelocity = rotationSpeed * Mathf.Deg2Rad;
        rb.angularVelocity = new Vector3(0, targetAngularVelocity, 0);
    }
}