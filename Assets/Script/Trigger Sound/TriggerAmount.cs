using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAmount : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip sound;
    [SerializeField] bool hasTriggered = false;
    [SerializeField] int amountTry = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !hasTriggered)
        {
            amountTry++;
            if(amountTry == 3)
            {
                hasTriggered = true;
                audioSource.clip = sound;
                audioSource.Play();
            }
        }
    }
}
