using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject defeatMenu;




    public void BacktoMenu()
    {
        SceneManager.LoadScene("MainMenu");
        defeatMenu.SetActive(false);
    }
    
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        defeatMenu.SetActive(false);
    }
}


