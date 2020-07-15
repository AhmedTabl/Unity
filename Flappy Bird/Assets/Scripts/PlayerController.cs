using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Inspector variables
    [SerializeField] private KeyCode jumpButton;
    [SerializeField] private float Speed;
    [SerializeField] private string nextLevel;
    [SerializeField] private float jumpForce;
    public GameObject victoryMenu;

    //Refrences
    private Rigidbody2D rb;

    //Other Variables


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        rb.velocity = new Vector2(Speed,rb.velocity.y);

        if (Input.GetKeyDown(jumpButton))
        {
            jump();
        }
    }
    private void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Win")
        {
            Time.timeScale = 0f;
            victoryMenu.SetActive(true);

        }
    }
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
