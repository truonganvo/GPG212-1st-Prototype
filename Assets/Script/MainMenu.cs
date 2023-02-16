using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int buttonPressCount = 0;
    [SerializeField] AudioSource audioSource;

    [SerializeField] AudioClip audio1;
    [SerializeField] AudioClip audio2;
    [SerializeField] AudioClip audio3;
    [SerializeField] AudioClip audio4;
    [SerializeField] AudioClip audio5;

    [SerializeField] GameObject subtitle1;
    [SerializeField] GameObject subtitle2;
    [SerializeField] GameObject subtitle3;
    [SerializeField] GameObject subtitle4;
    [SerializeField] GameObject subtitle5;



    [SerializeField] float disableTimer = 1f;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(subtitle1.activeSelf == true)
        {
            disableTimer -= Time.deltaTime;
            if (disableTimer <= 0)
            {
                subtitle1.SetActive(false);
            }
        }

        if (subtitle2.activeSelf == true)
        {
            disableTimer -= Time.deltaTime;
            if (disableTimer <= 0)
            {
                subtitle2.SetActive(false);
            }
        }

        if (subtitle3.activeSelf == true)
        {
            disableTimer -= Time.deltaTime;
            if (disableTimer <= 0)
            {
                subtitle3.SetActive(false);
            }
        }

        if (subtitle4.activeSelf == true)
        {
            disableTimer -= Time.deltaTime;
            if (disableTimer <= 0)
            {
                subtitle4.SetActive(false);
            }
        }

        if (subtitle5.activeSelf == true)
        {
            disableTimer -= Time.deltaTime;
            if (disableTimer <= 0)
            {
                subtitle5.SetActive(false);
            }
        }
    }

    public void PressButton()
    {
        buttonPressCount++;

        if (buttonPressCount == 5 )
        {
            audioSource.PlayOneShot(audio1);
            // When you activate the subtitile, it will also set the timer in the Update.
            //subtitile1.SetActive(true);
            //disableTimer = 1f;

            ActivateButton(subtitle1, audio1.length);
        }

        if (buttonPressCount == 25)
        {
            audioSource.PlayOneShot(audio2);
            ActivateButton(subtitle2, audio2.length);
        }

        if (buttonPressCount == 100)
        {
            audioSource.PlayOneShot(audio3);
            ActivateButton(subtitle3, audio3.length);
        }

        if (buttonPressCount == 135)
        {
            audioSource.PlayOneShot(audio4);
            ActivateButton(subtitle4, audio4.length);

        }

        if (buttonPressCount == 170)
        {
            audioSource.PlayOneShot(audio5);
            ActivateButton(subtitle5, audio5.length);
        }
    }

    /// <summary>
    /// This method will enable whatever gameobject you pass in to "buttonToActivate", then disable the object after a duration "visibleTimerDuration".
    /// </summary>
    /// <param name="buttonToActivate">The gameobject that you want to enable.</param>
    /// <param name="visibleTimerDuration">How long you want the gameobject to be enabled before it disables again.</param>
    private void ActivateButton(GameObject buttonToActivate, float visibleTimerDuration)
    {
        buttonToActivate.SetActive(true);
        disableTimer = visibleTimerDuration;
    }
}
