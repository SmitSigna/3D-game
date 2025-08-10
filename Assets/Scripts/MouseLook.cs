using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody; 
    public Transform playerCamera; 

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false;
    }

    void Update()
    {
        // Get mouse movement input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotate camera vertically (invert Y for natural feel)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Limit looking up/down
        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotate player body horizontally
        playerBody.Rotate(Vector3.up * mouseX);
    }
}

