using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour, IInteractable
{
    [SerializeField] private InventoryBase _shopInventory;

    private InventoryBase _clientInventory;

    public void Interact(GameObject interactor)
    {
        interactor.TryGetComponent<InventoryBase>(out _clientInventory);
        //Passar o inventário para o ui de venda
        //Opens shop ui
    }
}
