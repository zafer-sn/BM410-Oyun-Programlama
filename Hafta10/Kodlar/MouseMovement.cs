using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    float xRotation;
    float yRotation;

    public float mouseSensivity;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        yRotation += mouseX;

        gameObject.transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
