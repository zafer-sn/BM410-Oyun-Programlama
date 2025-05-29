using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventoryScreen;
    public bool isOpen;

    public static InventoryManager Instance { get; set; }

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        inventoryScreen.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && isOpen == false)
        {
            Cursor.lockState = CursorLockMode.None;
            inventoryScreen.SetActive(true);
            isOpen = true;
            // Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.I) && isOpen == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            inventoryScreen.SetActive(false);
            isOpen = false;
            // Time.timeScale = 1;
        }
    }
}
