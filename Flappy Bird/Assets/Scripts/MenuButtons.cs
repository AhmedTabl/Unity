using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject victoryMenu;
    public GameObject loseMenu;
    public GameObject pauseMenu;

    [SerializeField] private string nextLevel;


    //Pause Menu Buttnon Functions
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;

        }

    }

    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void mainMenu()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }



    //Main Menu Button Functions
    public void play()
    {

        SceneManager.LoadScene("Level 1");

    }
    public void quit()
    {

        Application.Quit();

    }
    public void HowToPlay()
    {
        
        SceneManager.LoadScene("HowToPlayMenu");

    }

    //HowToPlay Menu Back Button
    public void Back()
    {

        SceneManager.LoadScene(0);

    }


    //Victory Menu Button Functions
    public void nextLevelButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nextLevel);
        victoryMenu.SetActive(false);
    }
    public void restartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        victoryMenu.SetActive(false);
    }
}
