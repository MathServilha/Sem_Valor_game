using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{

    public bool paused = false;
    public GameObject pauseMenuUI;

    void Update()
    {
        Paused();
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }

    public void Paused()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (paused == false)
            {
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0;
                paused = true;
            }
            else
            {
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1;
                paused = false;
            }
        }
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Debug.Log("Game Closed");
        Application.Quit();
    }
}