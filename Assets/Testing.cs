using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public AudioSource testing;
    public float timing;
    public float time = 0;

    private bool Triggered = false;
    [SerializeField] Canvas canvas;



    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            timing += Time.deltaTime;
            if (timing >= time && !Triggered)
            {
                canvas.enabled = true;
                testing.Play();
                Triggered= true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.enabled = false;
        }
    }
}
