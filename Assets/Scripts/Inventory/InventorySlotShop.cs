using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlotShop : InventorySlotBase
{
    [Header("Parameters")]
    [SerializeField] private bool _buy;
    [SerializeField] private bool _sell;

    private InventoryUiShop _uiShop;

    public override void SetInventoryReference(InventoryUIBase iUIbase)
    {
        _uiShop = (InventoryUiShop)iUIbase;
    }

    public override void Use()
    {
        if(_item == null) return;

        if (_buy)
            Buy();

        if (_sell)
            Sell();
    }

    private void Buy()
    {
        //fazer as transações de moedas
        _uiShop.Inventory.Remove(_item);
        _uiShop.ClientInventory.AddItens(_item);
    }

    private void Sell()
    {
        //fazer as transações de moedas
        _uiShop.Inventory.Remove(_item);
        _uiShop.ClientInventory.AddItens(_item);
    }
}
