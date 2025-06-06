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
    public List<string> itemList = new List<string>();

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
        print("selam");
        whatSlotIsEquip = FindNextEmptySlot();
        itemToAdd = Instantiate(Resources.Load<GameObject>(itemName), whatSlotIsEquip.transform.position, whatSlotIsEquip.transform.rotation);
        itemToAdd.transform.SetParent(whatSlotIsEquip.transform);      
        itemList.Add(itemName);

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

    public void RemoveItem(string nameToRemove, int amountOfRemove)
    {
        int counter = amountOfRemove;
        for(int i = slotList.Count-1; i >= 0; i--)
        {
            if (slotList[i].transform.childCount > 0)
            {
                if (slotList[i].transform.GetChild(0).name == nameToRemove + "(Clone)" && counter != 0)
                {
                    Destroy(slotList[i].transform.GetChild(0).gameObject);
                    counter--;
                }
            }
        }
    }

    public void RefreshItemList()
    {
        itemList.Clear();
        foreach(GameObject slot in slotList)
        {
            if(slot.transform.childCount > 0)
            {
                itemList.Add(slot.transform.GetChild(0).name.Replace("Clone", ""));
            }
        }
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
