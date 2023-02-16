using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySubtitle : MonoBehaviour
{
    [SerializeField] GameObject subtitle;

    private void Start()
    {
        subtitle.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            subtitle.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            subtitle.SetActive(false);
        }
    }
}
