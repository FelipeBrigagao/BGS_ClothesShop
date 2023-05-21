using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop", menuName = "Character/Shop")]
public class ShopSO : ScriptableObject 
{
    public int MaxSlots;
    public List<ItemSO> Items;
}
