using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
// using UnityEngine.UI;

public class CraftingSystem : MonoBehaviour
{
    public static CraftingSystem Instance { get; set; }
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


    // Nesneyi açýp kapatmak için SetActive()
    // Bir component açýp kapatmak için enabled
    public GameObject craftingSystem;
    public GameObject toolsCategory;

    TMP_Text requirement1, requirement2;

    Button toolsBTN;
    Button craftBTN;

    public bool isOpen; // false

    Blueprint axeBLP = new Blueprint("Axe", "Stone", "Stick", 2, 2, 2);

    List<string> IMItemList = new List<string>();

    private void Start()
    {
        isOpen = false;
        craftBTN = toolsCategory.transform.Find("Image").Find("Button").GetComponent<Button>();
        craftBTN.onClick.AddListener(delegate { CraftAnyItem(axeBLP); });

        toolsBTN = craftingSystem.transform.Find("Button").GetComponent<Button>();
        toolsBTN.onClick.AddListener(delegate { OpenToolsCategory(); });

        requirement1 = toolsCategory.transform.Find("Image").Find("Requirement1").GetComponent<TMP_Text>();
        requirement2 = toolsCategory.transform.Find("Image").Find("Requirement2").GetComponent<TMP_Text>();

    }

    private void CraftAnyItem(Blueprint craftItemBlueprint)
    {
        print(craftItemBlueprint.itemName);
        InventoryManager.Instance.AddToInventory(craftItemBlueprint.itemName);

        InventoryManager.Instance.RemoveItem(craftItemBlueprint.requirement1Name, craftItemBlueprint.requirement1Amount);
        InventoryManager.Instance.RemoveItem(craftItemBlueprint.requirement2Name, craftItemBlueprint.requirement2Amount);

        InventoryManager.Instance.RefreshItemList();

        RefreshNeededItems();
    }

    private void RefreshNeededItems()
    {
        int stoneCount = 0;
        int stickCount = 0;
        IMItemList = InventoryManager.Instance.itemList;
        foreach(string item in IMItemList)
        {
            if(item == "Stone")
            {
                stoneCount++;
            } else if (item == "Stick")
            {
                stickCount++;
            }
        }

        requirement1.text = $"Stone 2 [{stoneCount}]";
        requirement2.text = $"Stick 2 [{stickCount}]";
    }

    public void OpenToolsCategory()
    {
        craftingSystem.SetActive(false);
        toolsCategory.SetActive(true);
    }

    private void Update()
    {
        RefreshNeededItems();
        if (Input.GetKeyDown(KeyCode.C) && isOpen == false)
        {
            Cursor.lockState = CursorLockMode.None;
            craftingSystem.SetActive(true);
            isOpen = true;
            // Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.C) && isOpen == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            craftingSystem.SetActive(false);
            toolsCategory.SetActive(false);
            isOpen = false;
            // Time.timeScale = 1;
        }
    }
}
