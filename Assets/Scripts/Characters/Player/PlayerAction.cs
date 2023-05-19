using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    [Header("Interaction parameters")]
    [SerializeField] private float _checkInteractablesRatio;
    [SerializeField] private Vector3 _checkOffset;
    [SerializeField] private LayerMask _interactablesLayer;

    private IInteractable _closestInteractable;
    private Collider2D[] _interactableColliders;

    private void Update()
    {
        CheckForInteractables();
    }

    public void InteractWithClosestObject()
    {
        if(_closestInteractable != null)
        {
            Debug.Log("Interacting");
            _closestInteractable.Interact();
        }
    }

    private void CheckForInteractables()
    {
        _interactableColliders = Physics2D.OverlapCircleAll(this.transform.position + _checkOffset, _checkInteractablesRatio, _interactablesLayer);

        if (_interactableColliders.Length <= 0)
        {
            if(_closestInteractable != null)
            {
                _closestInteractable = null;
                Debug.Log("No closest Object");
                //desligar UI de interagir
            }

            return;
        }

        foreach(Collider2D interactableCollider in _interactableColliders)
        {   
            if(interactableCollider.TryGetComponent<IInteractable>(out IInteractable interactable))
            {
                if(_closestInteractable != null)
                {
                    if((interactable.gameObject.transform.position - this.transform.position).magnitude < (_closestInteractable.gameObject.transform.position - this.transform.position).magnitude)
                    {
                        _closestInteractable = interactable;
                        Debug.Log(_closestInteractable.gameObject.name);
                        //trocar a ui de interagir de lugar
                    }
                }
                else
                {
                    _closestInteractable = interactable;
                    Debug.Log(_closestInteractable.gameObject.name);
                    //trocar a ui de interagir de lugar
                }
            }
        }

    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position + _checkOffset, _checkInteractablesRatio);
    }


}
