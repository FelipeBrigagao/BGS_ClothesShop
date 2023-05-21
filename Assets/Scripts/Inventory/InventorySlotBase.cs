using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotBase : MonoBehaviour
{
    private InventoryUIBase _inventoryUI;
    private Image _icon;
    private ItemSO _item;

    public void AddItem(ItemSO item)
    {
        _item = item;
        _icon.sprite = item.icon;
        _icon.enabled = true;
    }

    public void RemoveItem()
    {
        _item = null;
        _icon.enabled = false;
        _icon.sprite = null;
    }

    public void SetInventoryReference(InventoryUIBase iUIbase)
    {
        _inventoryUI = iUIbase;
    }

    public virtual void Use()
    {

    }
}
