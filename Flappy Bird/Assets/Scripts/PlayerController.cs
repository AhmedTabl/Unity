using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private KeyCode jumpButton;
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

        if (Input.GetKeyDown(jumpButton))
        {
            jump();
        }
    }

    private void jump()
    {
        rigidbody.velocity = new Vector2(0, jumpForce);
    }
}
