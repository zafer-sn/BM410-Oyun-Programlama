using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
// using UnityEngine.UI;

public class CraftingSystem : MonoBehaviour
{
    // Nesneyi açýp kapatmak için SetActive()
    // Bir component açýp kapatmak için enabled
    public GameObject craftingSystem;
    public GameObject toolsCategory;

    TMP_Text requirement1, requirement2;

    Button toolsBTN;
    Button craftBTN;

    bool isOpen; // false

    private void Start()
    {
        isOpen = false;
        craftBTN = craftingSystem.transform.Find("Button").GetComponent<Button>();
        craftBTN.onClick.AddListener(delegate { butonaTiklandi(); });

        toolsBTN = toolsCategory.transform.Find("Button").GetComponent<Button>();
        toolsBTN.onClick.AddListener(delegate { toolsButonunaTiklandi(); });

    }

    private void toolsButonunaTiklandi()
    {
        
    }

    public void butonaTiklandi()
    {
        craftingSystem.SetActive(false);
        toolsCategory.SetActive(true);
    }
}
