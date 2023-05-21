using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour, IInteractable
{
    [Header("Header")]
    [SerializeField] private ShopSO _shopInfo;
    [SerializeField] private InventoryBase _shopInventory;
    [SerializeField] private InventoryUiShop _buyUi;
    [SerializeField] private InventoryUiShop _sellUi;

    private InventoryBase _clientInventory;

    public void Init()
    {
        _shopInventory.SetMaxSlots(_shopInfo.MaxSlots);
        
        foreach(ItemSO item in _shopInfo.Items)
        {
            _shopInventory.AddItens(item);
        }

        _buyUi.SetInventory(_shopInventory);
        _sellUi.SetOtherInventory(_shopInventory);
    }

    public void Interact(GameObject interactor)
    {
        interactor.TryGetComponent<InventoryBase>(out _clientInventory);
        _sellUi.SetInventory(_clientInventory);
        _buyUi.SetOtherInventory(_clientInventory);
        //Opens shop ui
    }
}
