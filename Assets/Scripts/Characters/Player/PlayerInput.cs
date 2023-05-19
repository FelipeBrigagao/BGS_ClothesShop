using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Player _player;

    [Header("Parameters")]
    [SerializeField] private KeyCode _interactionKey;
    [SerializeField] private KeyCode _inventoryKey;

    private bool _canReceiveInputs;
    private Vector2 _input;

    private void Start()
    {
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        if (_canReceiveInputs)
        {
            ReceiveMoveInputs();

        }
    }

    private void ReceiveMoveInputs()
    {
        _input.x = Input.GetAxisRaw("Horizontal");
        _input.y = Input.GetAxisRaw("Vertical");
        _player.CharacterMovement.SetInput(_input);
    }

    private void CheckForINteraction()
    {
        if (Input.GetKeyDown(_inventoryKey))
        {
            //interact
        }
    }

    public void StartReceivingInputs()
    {
        _canReceiveInputs = true;
    }

    public void StopReceivingInputs()
    {
        _canReceiveInputs = false;
    }


}