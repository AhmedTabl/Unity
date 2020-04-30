using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private KeyCode jumpButton;
    [SerializeField] private string NextLevel;
    [SerializeField] private Rigidbody2D levelForeground;
    [SerializeField] private Rigidbody2D levelBackground;
    [SerializeField] private float levelSpeed;
    [SerializeField] private float jumpForce;
    private Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        levelForeground.velocity = new Vector2(-levelSpeed , 0);
        levelBackground.velocity = new Vector2(-levelSpeed, 0);

        PlayerMovement();
    }

    private void PlayerMovement()
    {
        if (Input.GetKeyDown(jumpButton))
        {
            jump();
        }
    }
    private void jump()
    {
        rigidbody.velocity = new Vector2(0, jumpForce);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Win")
        {
            SceneManager.LoadScene(NextLevel);
        }
    }
}
