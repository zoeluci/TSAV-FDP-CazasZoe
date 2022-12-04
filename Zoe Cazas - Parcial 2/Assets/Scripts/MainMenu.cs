using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void goToPrototype()
    {
        SceneManager.LoadScene(1);
    }

    public void goToMainSceneFinal()
    {
        SceneManager.LoadScene(2);
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
