using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartWithButton : MonoBehaviour
{
    [SerializeField] private KeyCode RestartButton;

    void Update()
    {
        if (Input.GetKeyDown(RestartButton))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
