using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    private MenuButtons MenuB;

    private void Start()
    {
        MenuB = GetComponent<MenuButtons>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {

            MenuB.loseMenu.SetActive(true);
            Time.timeScale = 0f;

        }
    }
}
