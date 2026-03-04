using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableItemScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 startTransform;
    private bool dragging;
    void Awake()
    {
        startTransform = transform.position;
        dragging = false;
    }
    private void Update()
    {
        if (dragging == false) 
        {
            transform.position = startTransform;
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        dragging = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = startTransform;
        dragging=false;
    }
}
