using UnityEngine;
using TMPro;

public class SelectionManager : MonoBehaviour
{
	// public int Yas {get; set;}
	public TMP_Text interactableText;
	public bool onTarget;
	// float rayDistance = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactableText.text = "";
		RenderSettings.fog = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Ray ray = new Ray(new Vector3(1f, 2f, 3f), new Vector3(1f,1f,1f));
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit))
		{
			Transform selectionTransform = hit.transform;
			if(selectionTransform.GetComponent<InteractableObject>() && 
			selectionTransform.GetComponent<InteractableObject>().playerInRange
			)
			{
				onTarget = true;
				interactableText.text = selectionTransform.GetComponent<InteractableObject>().GetItemName();
			}
			else
			{
				onTarget = false;
				interactableText.text = "";
			}
		}
		else
		{
			onTarget = false;
			interactableText.text = "";
		}
		// Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.yellow);			
		
    }
}
