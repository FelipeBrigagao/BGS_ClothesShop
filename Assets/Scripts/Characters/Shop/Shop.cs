using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour, IInteractable
{
    [Header("Header")]
    [SerializeField] private ShopSO _shopInfo;
    [SerializeField] private InventoryBase _shopInventory;
    [SerializeField] private InventoryUiShop _sellUi;
    [SerializeField] private InventoryUiShop _buyUi;

    private InventoryBase _clientInventory;

    public void Init()
    {
        _shopInventory.SetMaxSlots(_shopInfo.MaxSlots);
        
        foreach(ItemSO item in _shopInfo.Items)
        {
            _shopInventory.AddItens(item);
        }

        _sellUi.SetInventory(_shopInventory);
        _buyUi.SetOtherInventory(_shopInventory);
    }

    public void Interact(GameObject interactor)
    {
        interactor.TryGetComponent<InventoryBase>(out _clientInventory);
        _buyUi.SetInventory(_clientInventory);
        _sellUi.SetOtherInventory(_clientInventory);
        //Opens shop ui
    }
}
