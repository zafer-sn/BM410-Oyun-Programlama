using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    // ORM -> Object Relational Mapping
    // [Key]
    // [AutoIncrement]
    // public int ID { get; set; }

    /*[HideInInspector] -> Inspectorda gizler
    [SerializeField] -> private olsa bile Editörde gösterir*/ 
    CanvasGroup canvasGroup;
    RectTransform rectTransform;

    // public int MyProperty { get; set; } -> Editörde görünmez
    Vector3 startPosition;
    Transform startParent;

    public static GameObject itemBeingDragged;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.LogWarning("Sürükleme baþladý...");
        canvasGroup.alpha = 0.5f;
        canvasGroup.blocksRaycasts = false;

        startPosition = transform.position;
        startParent = transform.parent;

        transform.SetParent(transform.root);
        itemBeingDragged = gameObject;
    }    

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        if(transform.parent == startParent || transform.parent == transform.root)
        {
            transform.position = startPosition;
            transform.parent = startParent;
        }
        Debug.LogWarning("Sürükleme bitti...");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.LogWarning("Sürükleme devam ediyor...");
        rectTransform.anchoredPosition += eventData.delta;
    }
}
