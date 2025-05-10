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
		if(Input.GetKeyDown(KeyCode.Mouse0) && playerInRange)
		{
			Destroy(gameObject);
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
