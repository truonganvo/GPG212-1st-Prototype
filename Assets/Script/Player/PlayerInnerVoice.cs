using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInnerVoice : MonoBehaviour
{
    //Optional SFX
    public AudioClip voice1;

    //Standing Still - Optional Feature for future games
    private float timer;
    private Vector3 previousPosition;
    private bool triggered = false;

    private void FixedUpdate()
    {

        //Optional Feature - Standing Still
        if (IsStill())
        {
            timer += Time.deltaTime;

            if (timer >= 10 && !triggered)
            {
                Debug.Log("Player has been standing still for " + timer + " seconds.");
                PlaySound();
                triggered = true;
            }
        }
        else
        {
            timer = 0;
            triggered = false;
        }

        previousPosition = transform.position;
    }

    //Optional Features HERE:

    //Standing Still
    private bool IsStill()
    {
        return transform.position == previousPosition;
    }

    private void PlaySound()
    {
        AudioSource.PlayClipAtPoint(voice1, transform.position);
    }
}
