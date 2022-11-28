using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public bool pauseOn;

    public void play()
    {
        pauseOn = !pauseOn;
        Time.timeScale = 1;
    }

    public void changeScene()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseOn = !pauseOn;
            pausePanel.SetActive(pauseOn);

            if (!pauseOn)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
        }
    }
}
