using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void goToMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void goToTerrainScene()
    {
        SceneManager.LoadScene(2);
    }

    public void goToProBuilderScene()
    {
        SceneManager.LoadScene(3);
    }

    public bool pauseOn;

    public void play()
    {
        pauseOn = !pauseOn;
        Time.timeScale = 1;
    }

    public void quitApp()
    {
        Application.Quit();
    }
}
