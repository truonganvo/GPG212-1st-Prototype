using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] AudioSource testing;
    [SerializeField] float timing;
    [SerializeField] float time = 0;

    private bool Triggered = false;
    [SerializeField] Canvas canvas;
    [SerializeField] GameObject subtitle;




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
                subtitle.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.enabled = false;
            if (subtitle.activeSelf == true)
            {
                subtitle.SetActive(false);
            }

        }
    }
}
