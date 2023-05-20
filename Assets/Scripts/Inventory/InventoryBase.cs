using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBase : MonoBehaviour
{
    [SerializeField] private List<ItemSO> _itens;

    private int _maxSlots;


    //public bool AddItens(ItemSO item)
    //{

    //}


    public void SetMaxSlots(int maxSlots)
    {
        _maxSlots = maxSlots;
    }

}
