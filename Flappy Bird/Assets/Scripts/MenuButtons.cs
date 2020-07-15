using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
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
    public void Back()
    {

        SceneManager.LoadScene(0);

    }
}
