using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    private VictoryMenu vicMenu;

    private void Start()
    {
        vicMenu = GetComponent<VictoryMenu>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {

            vicMenu.loseMenu.SetActive(true);
            Time.timeScale = 0f;

        }
    }
}
