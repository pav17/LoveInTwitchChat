using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(sceneName: "MainMap");
    }

    public void Options()
    {
        SceneManager.LoadScene(sceneName: "Options");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(sceneName: "Tutorial");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
