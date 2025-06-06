using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mouseSensivity;
    float xRotation;
    float yRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(!InventoryManager.Instance.isOpen && !CraftingSystem.Instance.isOpen)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            yRotation += mouseX;

            gameObject.transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }
    }
}
