using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] Transform interactionPoint;
    [SerializeField] float interactionPositionRadius = 0.5f;
    [SerializeField] LayerMask interactableMask;

    private readonly Collider[] colliders= new Collider[4];
    [SerializeField] int numFound;

    private void Update()
    {
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position, interactionPositionRadius, colliders, interactableMask);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionPoint.position, interactionPositionRadius);
    }
}
