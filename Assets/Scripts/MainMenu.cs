using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadScene("Swipe Level");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

