using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject panel;
    bool isPaused;

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if(isPaused)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void Continue()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
        isPaused = false;
    }
  
    public void quit()
    {
        Application.Quit();
    }
    public void mainmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void room()
    {
        SceneManager.LoadScene(2);
        figures.item1 = 0;
        figures.item2 = 0;
        figures.item3 = 0;
        figures.item4 = 0;
        figures.item5 = 0;
    }
    public void settings()
    {
        SceneManager.LoadScene(1);
    }
}
