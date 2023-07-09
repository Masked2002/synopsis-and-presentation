using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float sensitivity = 100f;  // Mouse sensitivity

    private float yaw = 0f;  // Camera rotation around the y-axis
    private float pitch = 0f;  // Camera rotation around the x-axis

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Calculate rotation values
        yaw += mouseX;
        pitch -= mouseY;
        pitch = Mathf.Clamp(pitch, -90f, 90f);  // Clamp pitch to prevent camera flipping

        // Apply rotations to the camera
        transform.eulerAngles = new Vector3(pitch, yaw, 0f);
    }
}