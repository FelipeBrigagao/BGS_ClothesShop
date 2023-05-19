using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private PlayerAction _playerAction;
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private PlayerUI _playerUI;

    public PlayerMovement PlayerMovement { get => _playerMovement;}
    public PlayerInput PlayerInput { get => _playerInput;}
    public PlayerAction PlayerAction { get => _playerAction;}
    public PlayerAnimation PlayerAnimation { get => _playerAnimation;}
    public PlayerUI PlayerUI { get => _playerUI;}

    private void Start()
    {
        InitPlayer();
    }

    public void InitPlayer()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerInput = GetComponent<PlayerInput>();
        _playerAction = GetComponent<PlayerAction>();
        _playerAnimation = GetComponent<PlayerAnimation>();
        _playerUI = GetComponent<PlayerUI>();

        _playerInput.StartReceivingInputs();
        _playerMovement.StartMovement();
    }

}
