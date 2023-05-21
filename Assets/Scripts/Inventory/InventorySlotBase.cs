using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotBase : MonoBehaviour
{
    protected InventoryUIBase _inventoryUI;
    protected Image _icon;
    protected ItemSO _item;

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

    public virtual void SetInventoryReference(InventoryUIBase iUIbase)
    {
        _inventoryUI = iUIbase;
    }

    public virtual void Use()
    {

    }
}
