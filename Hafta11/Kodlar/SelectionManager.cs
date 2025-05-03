using UnityEngine;
using TMPro;

public class SelectionManager : MonoBehaviour
{
	public TMP_Text interactableText;
	float rayDistance = 10f;
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
		if(Physics.Raycast(ray, out hit, rayDistance))
		{
			Transform selectionTransform = hit.transform;
			if(selectionTransform.GetComponent<InteractableObject>())
			{
				interactableText.text = selectionTransform.GetComponent<InteractableObject>().GetItemName();
			}
			else
			{
				interactableText.text = "";
			}
		}
		else
		{
			interactableText.text = "";
		}
		Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.yellow);			
		
    }
}
