using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassaFase : MonoBehaviour
{
    // Start is called before the first frame update
    public bool paused = false;
    public GameObject winMenuUI;
    [SerializeField] string proximaFase;

    void OnEnable()
    {
        Debug.Log("PrintOnEnable: script was enabled");
        Paused();
    }

    public void Paused()
    {
            if (paused == false)
            {
                Time.timeScale = 0;
                paused = true;

            }
    }
    public void BacktoMenu()
    {
        Time.timeScale = 1;
        
        SceneManager.LoadScene("MainMenu");
        winMenuUI.SetActive(false);
    }
    
    public void NextLevel()
    {

        Time.timeScale = 1;
        
        SceneManager.LoadScene(proximaFase);
        winMenuUI.SetActive(false);
    }
}
