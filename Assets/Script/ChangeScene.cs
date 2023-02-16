using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void PressButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void PressBackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
