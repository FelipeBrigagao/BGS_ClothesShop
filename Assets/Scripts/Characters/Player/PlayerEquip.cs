using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquip : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Player _player;

    [SerializeField] private ClothesSO _testHeadClothes;
    [SerializeField] private ClothesSO _testTorsoClothes;
    [SerializeField] private ClothesSO _testLegsClothes;

    private ClothesSO _currentBodyClothes;
    private ClothesSO _currentHeadClothes;
    private ClothesSO _currentTorsoClothes;
    private ClothesSO _currentLegsClothes;


    public void InitPlayerClothes()
    {
        SwitchClothes(_player.PlayerSO.BaseBodyClothes);
        SwitchClothes(_player.PlayerSO.BaseHeadClothes);
        SwitchClothes(_player.PlayerSO.BaseTorsoClothes);
        SwitchClothes(_player.PlayerSO.BaseLegsClothes);
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            SwitchClothes(_testHeadClothes);
            SwitchClothes(_testTorsoClothes);
            SwitchClothes(_testLegsClothes);
        }
    }


    public void ChangePiece(ItemSO newItem)
    {
        switch (newItem.itemType)
        {
            case ItemTypes.CLOTHING:
                SwitchClothes((ClothesSO)newItem);
                break;
            case ItemTypes.WEAPON:
                Debug.Log("How you have a weapon?");
                break;
            default:
                break;
        }
    }

    private void SwitchClothes(ClothesSO newClothes)
    {
        switch(newClothes.ClothesPart)
        {
            case ClothesParts.Body:
                ChangeClothesAux(_currentBodyClothes, newClothes, _player.PlayerSO.BaseBodyClothes);
                break;
            case ClothesParts.Head:
                ChangeClothesAux(_currentHeadClothes, newClothes, _player.PlayerSO.BaseHeadClothes);
                break;
            case ClothesParts.Torso:
                ChangeClothesAux(_currentTorsoClothes, newClothes, _player.PlayerSO.BaseTorsoClothes);
                break;
            case ClothesParts.Legs:
                ChangeClothesAux(_currentLegsClothes, newClothes, _player.PlayerSO.BaseLegsClothes);
                break;
            default:
                break;

        }
    }

    private void ChangeClothesAux(ClothesSO currentClothes, ClothesSO newClothes, ClothesSO baseClothes)
    {

        Debug.Log($"{baseClothes.ClothesPart}{newClothes.ClothesPart}");

        if (currentClothes != null)
        {
            if (!currentClothes.IsBase)
            {
                //retirar e devolver ao inventário se não for a base
            }
        }

        currentClothes = newClothes;
        _player.PlayerAnimation.ChangeAnimSprites(baseClothes, currentClothes);
    }

}
