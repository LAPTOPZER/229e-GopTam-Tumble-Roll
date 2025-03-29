using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 5.0f;
    public float height = 2.0f;
    public float rotationSpeed = 2.0f;

    private float currentRotationAngle = 0.0f;

    void Update()
    {
        if (target == null) return;

        float horizontalInput = Input.GetAxis("Horizontal");

        currentRotationAngle += horizontalInput * rotationSpeed;

        Quaternion rotation = Quaternion.Euler(0, currentRotationAngle, 0);
        Vector3 offset = rotation * new Vector3(0, height, -distance);

        transform.position = target.position + offset;
        transform.LookAt(target.position);
    }
}
