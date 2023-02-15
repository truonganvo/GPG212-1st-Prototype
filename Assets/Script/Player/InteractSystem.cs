using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractSystem : MonoBehaviour
{
    public float interactionRadius = 3f;
    public int interactionCount = 0;

    [SerializeField] bool playerInRange;


    public GameObject DestroyIt;
    [SerializeField] AudioClip talking;


    private void Update()
    {
        if (playerInRange = true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Player interacted with object: " + gameObject.name);
            interactionCount++;

            if (interactionCount == 5)
            {
                PlaySound();
            }

            else if (interactionCount > 30)
            {
                DestroyAnObject();
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactionRadius);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    public void DestroyAnObject()
    {
        Destroy(DestroyIt);
    }
    private void PlaySound()
    {
        AudioSource.PlayClipAtPoint(talking, transform.position);
    }
}
