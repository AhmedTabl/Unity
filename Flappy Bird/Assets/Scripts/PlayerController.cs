using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Inspector variables
    [SerializeField] private KeyCode jumpButton;
    [SerializeField] private string NextLevel;
    [SerializeField] private float Speed;
    [SerializeField] private float jumpForce;

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
            SceneManager.LoadScene(NextLevel);

        }
    }
}
