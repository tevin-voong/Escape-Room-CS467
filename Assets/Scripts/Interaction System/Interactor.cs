using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
   [SerializeField] private Transform _interactionPoint;
   [SerializeField] private float _interactionPointRadius = 0.5f;
   [SerializeField] private LayerMask _interactableMask;

   private readonly Collider[] _colliders = new Collider[3];
   [SerializeField] private int _numFound;

   private void Update()
   {     
      // determines whether character is within distance to interact with something
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionPointRadius, _colliders, _interactableMask);

         // if character is colliding with something, gives option to interact with object by pressing e
        if (_numFound > 0)
        {
            var interactable = _colliders[0].GetComponent<IInteractable>();

            if (interactable != null && Keyboard.current.eKey.wasPressedThisFrame)
            {
               interactable.Interact(interactor:this);
            }
        }
   }

   // Setting color of the intereaction sphere
   private void OnDrawGizmos()
   {
    Gizmos.color = Color.white;
    Gizmos.DrawWireSphere(_interactionPoint.position, _interactionPointRadius);
   }
}
