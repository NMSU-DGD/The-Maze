﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.Networking;

public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    public int slot;
    private Inventory inv;
    private Vector2 _offset;
    private Tooltip tooltip;

    void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        tooltip = inv.GetComponent<Tooltip>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (item != null)
        {
             _offset = eventData.position - new Vector2 (this.transform.position.x, this.transform.position.y);
            this.transform.SetParent(this.transform.parent.parent);
            this.transform.position = eventData.position - _offset;
            GetComponent<CanvasGroup>().blocksRaycasts = false;

        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (item != null)
        {
            this.transform.position = eventData.position - _offset;

        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(inv.slots[slot].transform);
        this.transform.position = inv.slots[slot].transform.position;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (item != null)
        {
            _offset = eventData.position - new Vector2(this.transform.position.x, this.transform.position.y);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltip.Activate(item);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.Deactivate();
    }
}
