using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableItemScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 startTransform;
    private PlayerController controller;

    private void Start()
    {
        controller = GameObject.Find("WorkshopCam").GetComponent<PlayerController>();
    }

    void Awake()
    {
        startTransform = transform.position;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        controller.dragging = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        controller.dragging = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        controller.dragging = false;
        transform.position = startTransform;
    }
}
