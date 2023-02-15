using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int buttonPressCount = 0;
    [SerializeField] AudioSource audioSource;

    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;
    public AudioClip audio5;




    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PressButton()
    {
        buttonPressCount++;

        if (buttonPressCount == 5 )
        {
            audioSource.PlayOneShot(audio1);
        }

        if (buttonPressCount == 25)
        {
            audioSource.PlayOneShot(audio2);
        }

        if (buttonPressCount == 100)
        {
            audioSource.PlayOneShot(audio3);
        }

        if (buttonPressCount == 135)
        {
            audioSource.PlayOneShot(audio4);
        }

        if (buttonPressCount == 150)
        {
            audioSource.PlayOneShot(audio5);
        }
    }
}
