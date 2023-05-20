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
    [SerializeField] private string _walkingAnimationKey;

    private bool _isMoving;
    private bool _facingRight = false;

    private Vector3 _scale;

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        _player = GetComponent<Player>();
    }

    public void SetWalkingAnimation(Vector2 input)
    {
        if (input.magnitude > 0.01f)
        {
            _isMoving = true;

            if(_facingRight && input.x < 0) 
            {
                ChangeFacingSide(false);
            }else if (!_facingRight && input.x > 0)
            {
                ChangeFacingSide(true);
            }

        }
        else
        {
            _isMoving = false;
        }

        _animator.SetBool(_walkingAnimationKey, _isMoving);
    }

    private void ChangeFacingSide(bool changeSide)
    {
        _facingRight = changeSide;
        _scale = _playerModel.localScale;
        _scale.x *= -1;
        _playerModel.localScale = _scale;
    }


}
