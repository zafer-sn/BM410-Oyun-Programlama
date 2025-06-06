using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public string itemName;
	
	public bool playerInRange;
	
	public string GetItemName()
	{
		return itemName;		
	}
	
	private void Update()
	{
		if(SelectionManager.selectedObject == gameObject && Input.GetKeyDown(KeyCode.Mouse0) && playerInRange && SelectionManager.onTarget)
		{
			if (!InventoryManager.Instance.CheckIfFull())
			{
				InventoryManager.Instance.AddToInventory(itemName);
				Destroy(gameObject);
			}
			else
			{
				Debug.Log("Envanter dolu");
			}
			
		}		
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			playerInRange = true;
		}		
	}
	
	private void OnTriggerExit(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			playerInRange = false;
		}		
	}
}
