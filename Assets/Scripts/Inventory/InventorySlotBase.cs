using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotBase : MonoBehaviour
{
    private Image _icon;
    private ItemSO _item;

    public void AddItem(ItemSO item)
    {
        _item = item;
        _icon.sprite = item.icon;
    }

    public void RemoveItem()
    {
        _icon = null;
    }
}
