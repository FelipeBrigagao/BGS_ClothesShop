using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUiShop : InventoryUIBase
{
    private InventoryBase _otherInventory;

    public InventoryBase OtherInventory { get => _otherInventory;}

    public void SetOtherInventory(InventoryBase otherInventory)
    {
        _otherInventory = otherInventory;
    }
}
