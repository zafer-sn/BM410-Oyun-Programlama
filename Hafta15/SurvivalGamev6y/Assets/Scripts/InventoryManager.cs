using System;
using System.Collections.Generic;
using UnityEngine;


public class InventoryManager : MonoBehaviour
{
    public GameObject inventoryScreen;
    public bool isOpen;

    public GameObject itemToAdd;
    int[] dizi = { 1, 2, 3 }; // 12 bayt - 18 bayt

    public GameObject whatSlotIsEquip;

    public List<GameObject> slotList = new List<GameObject>();

    // Singleton - Design Pattern
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
        PopulateSlotList();
    }

    private void PopulateSlotList()
    {
        foreach(Transform child in inventoryScreen.transform)
        {
            if(child.childCount == 0)
            {
                if(child.gameObject.CompareTag("Slot"))
                {
                    slotList.Add(child.gameObject);
                }                
            }
        }        
    }
    public bool CheckIfFull()
    {
        int counter = 0;
        foreach(GameObject slot in slotList)
        {
            if(slot.transform.childCount > 0)
            {
                counter++;
            }
        }
        if(counter == slotList.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void AddToInventory(string itemName)
    {
        
        whatSlotIsEquip = FindNextEmptySlot();
        itemToAdd = Instantiate(Resources.Load<GameObject>(itemName), whatSlotIsEquip.transform.position, whatSlotIsEquip.transform.rotation);
        itemToAdd.transform.SetParent(whatSlotIsEquip.transform);      
        
    }

    public GameObject FindNextEmptySlot()
    {
        foreach(GameObject slot in slotList)
        {            
            if(slot.transform.childCount == 0)
            {
                return slot;
            }
        }
        return new GameObject();
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
