using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasEnable : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    public void OnEnable()
    {
        canvas.enabled = true;
    }

    public void OnDisable()
    {
        canvas.enabled = false;
    }
}
