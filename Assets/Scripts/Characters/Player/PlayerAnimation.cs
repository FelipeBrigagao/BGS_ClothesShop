using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerAnimation : MonoBehaviour
{
    [Header("Animation references")]
    [SerializeField] private Player _player;
    [SerializeField] private Transform _playerModel;
    [SerializeField] private Animator _animator;
    
    [Header("Animation parameters")]
    [SerializeField] private string _walkingHorizontalAnimationKey;
    [SerializeField] private string _walkingVerticalAnimationKey;
    [SerializeField] private string _walkingSpeedAnimationKey;

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        _player = GetComponent<Player>();
    }

    public void SetWalkingAnimation(Vector2 input)
    {
        if(input.magnitude > 0)
        {
            _animator.SetFloat(_walkingHorizontalAnimationKey, input.x);
            _animator.SetFloat(_walkingVerticalAnimationKey, input.y);
        }

        _animator.SetFloat(_walkingSpeedAnimationKey, input.magnitude);
    }

}
