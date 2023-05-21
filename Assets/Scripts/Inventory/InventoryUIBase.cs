using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIBase : MonoBehaviour
{
    [Header("References")]
    [SerializeField] protected Transform _slotsHolder;
    [SerializeField] protected InventorySlotBase _slotPrefab;

    protected List<InventorySlotBase> _slots = new List<InventorySlotBase>();

    protected InventoryBase _inventory;

    public InventoryBase Inventory { get => _inventory;}

    public void SetInventory(InventoryBase inventory)
    {
        if (_inventory)
        {
            _inventory.OnItemChange -= UpdateSlots;
        }

        _inventory = inventory;
        _inventory.OnItemChange += UpdateSlots;
        SetSlots(_inventory.MaxSlots);
    }

    public void SetSlots(int slotsAmount)
    {
        if(_slots.Count > 0)
        {
            if(_slots.Count > slotsAmount)
            {
                for(int j = slotsAmount; j < _slots.Count; j++)
                {
                    Destroy(_slots[slotsAmount].gameObject);
                    _slots.RemoveAt(slotsAmount);
                }

                UpdateSlots();
            }
            else if(_slots.Count < slotsAmount)
            {
                slotsAmount -= _slots.Count;
                CreateSlots(slotsAmount);
            
            }else if (_slots.Count == slotsAmount)
            {
                UpdateSlots();
            }

            ResetSlotsReference();
            return;
        }

        CreateSlots(slotsAmount);
    }

    protected void CreateSlots(int slotsAmount)
    {
        InventorySlotBase newSlot;

        for (int i = 0; i < slotsAmount; i++)
        {
            newSlot = Instantiate(_slotPrefab, _slotsHolder);
            _slots.Add(newSlot);
            newSlot.SetInventoryReference(this);
        }
    }

    protected void ResetSlotsReference()
    {
        foreach(InventorySlotBase slot in _slotsHolder)
        {
            slot.SetInventoryReference(this);
        }
    }

    public void UpdateSlots()
    {
        for(int i = 0; i < _slots.Count; i++)
        {
            if(i < _inventory.Itens.Count)
            {
                _slots[i].AddItem(_inventory.Itens[i]);
            }
            else
            {
                _slots[i].RemoveItem();
            }
        }
    }


}
