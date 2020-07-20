using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject victoryMenu;
    public GameObject loseMenu;
    public GameObject pauseMenu;
    [SerializeField] private AudioSource buttonSound;
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
        buttonSound.Play();
    }
    public void mainMenu()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        buttonSound.Play();
    }



    //Main Menu Button Functions
    public void play()
    {

        SceneManager.LoadScene("Level 1");
        buttonSound.Play();

    }
    public void quit()
    {

        Application.Quit();
        buttonSound.Play();

    }
    public void HowToPlay()
    {
        
        SceneManager.LoadScene("HowToPlayMenu");
        buttonSound.Play();

    }
    public void LevelsMenu()
    {

        SceneManager.LoadScene("LevelsMenu");
        buttonSound.Play();

    }


    //HowToPlay Menu Back Button
    public void Back()
    {

        SceneManager.LoadScene(0);
        buttonSound.Play();
    }


    //Victory Menu Button Functions
    public void nextLevelButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nextLevel);
        victoryMenu.SetActive(false);
        buttonSound.Play();
    }
    public void restartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        victoryMenu.SetActive(false);
        buttonSound.Play();
    }


    //Levels Menu Button Functions
    public void GoToLevel1()
    {

        SceneManager.LoadScene("Level 1");
        buttonSound.Play();
    }
    public void GoToLevel2()
    {

        SceneManager.LoadScene("Level 2");
        buttonSound.Play();
    }
    public void GoToLevel3()
    {

        SceneManager.LoadScene("Level 3");
        buttonSound.Play();
    }
}
