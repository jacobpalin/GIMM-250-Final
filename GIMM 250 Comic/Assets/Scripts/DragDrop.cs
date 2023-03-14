using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    //IDragHandler
    public void OnDrag(PointerEventData eventData)
    {

        //move object along side the mouse
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    //IEndDragHandler
    public void OnEndDrag(PointerEventData eventData)
    {

    }

    //IBeginDragHandler
    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    //IPointerDownHandler
    public void OnPointerDown(PointerEventData eventData)
    {

    }
}
