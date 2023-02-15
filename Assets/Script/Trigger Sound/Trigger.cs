using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public AudioSource testing;
    public float timing;
    public float time = 0;

    private bool Triggered = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timing += Time.deltaTime;
            if (timing >= time && !Triggered)
            {
                testing.Play();
                Triggered = true;
            }
        }
    }
}
