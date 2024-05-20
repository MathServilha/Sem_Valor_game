using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }

    public void ExitGame()
    {
        Debug.Log("Game Closed");
        Application.Quit();
    }
}
