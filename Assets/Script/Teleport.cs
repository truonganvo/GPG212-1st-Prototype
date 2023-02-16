using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    public GameObject player;
    public GameObject camera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = teleportPoint.position;
            camera.transform.position = teleportPoint.position;
            camera.transform.rotation = teleportPoint.rotation;
        }
    }
}
