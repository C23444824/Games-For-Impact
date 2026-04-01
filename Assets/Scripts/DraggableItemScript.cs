using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItemScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 startTransform;
    private PlayerController controller;
    private bool canDrag;
    public GameObject Corner;

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
        canDrag = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(canDrag)
        transform.position = Input.mousePosition;
        controller.dragging = true;
        RaycastHit hit;
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(r, out hit) && hit.transform.tag == "Hole" && gameObject.tag == "Patch")
        {
            List<Transform> anchors = new List<Transform>();
            foreach (Transform child in hit.transform)
            {
                anchors.Add(child);
            }
            Destroy(hit.transform.gameObject);
            canDrag = false;
            foreach (var anchor in anchors)
            {
                Instantiate(Corner, anchor.transform);
            }
        }
        if (Physics.Raycast(r, out hit) && hit.transform.tag == "Corners" && gameObject.tag == "Needle")
        {
            Destroy(hit.transform.gameObject);
            canDrag = false;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        controller.dragging = false;
        transform.position = startTransform;
        canDrag = true;
    }
}
