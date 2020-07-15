using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public GameObject victoryMenu;
    public GameObject loseMenu;
    [SerializeField] private string nextLevel;

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
