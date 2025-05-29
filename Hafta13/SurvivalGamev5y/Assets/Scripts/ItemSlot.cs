using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public GameObject Item
    {
        get
        {
            if(transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(Item == null)
        {
            DragDrop.itemBeingDragged.transform.SetParent(gameObject.transform);
            DragDrop.itemBeingDragged.transform.localPosition = Vector3.zero;
            // DragDrop.itemBeingDragged.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
        }
    }
}
