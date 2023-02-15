using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sound;
    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !hasTriggered)
        {
            hasTriggered = true;
            audioSource.clip = sound;
            audioSource.Play();
        }
    }
}
