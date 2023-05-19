using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private CharacterMovement _characterMovement;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private PlayerAnimation _playerAnimation;

    public CharacterMovement CharacterMovement { get => _characterMovement;}
    public PlayerInput PlayerInput { get => _playerInput;}
    public PlayerAnimation PlayerAnimation { get => _playerAnimation;}


    private void Start()
    {
        InitPlayer();
    }

    public void InitPlayer()
    {
        _playerInput.StartReceivingInputs();
        _characterMovement.StartMovement();
    }

}
