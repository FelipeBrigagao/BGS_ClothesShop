using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Player _player;
    [SerializeField] private Transform _interactionButtonHolder;
    [SerializeField] private Transform _interactionButton;

    [Header("Parameters")]
    [SerializeField] private Vector3 _interactButtonOffset;

    public void PositionInteractButton(GameObject positionObject)
    {
        TurnInteractionButtonON();
        _interactionButton.SetParent(positionObject.transform);
        _interactionButton.localPosition = _interactButtonOffset;
    }

    public void TurnInteractionButtonON()
    {
        _interactionButton.gameObject.SetActive(true);
    }

    public void TurnInteractionButtonOFF()
    {
        _interactionButton.gameObject.SetActive(false);
        _interactionButton.SetParent(_interactionButtonHolder);
    }

}
