using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private Animator anime;
    public Joystick joystick;
    private enum State { idle, running, jumping , falling};
    private Collider2D collider;
    [SerializeField]private LayerMask ground;
    private State state = State.idle;

    public float speed = 20f;
    public float jumpForce = 50f;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        collider = GetComponent< CapsuleCollider2D>();

    }

    private void Update()
    {
       float  horizontal_dirction = Input.GetAxis("Horizontal");
       
        if (horizontal_dirction < 0)
        {

            rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
            transform.localScale = new Vector3(-4, 4, 1);

        }
        else if (horizontal_dirction >0)
        {

            rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
            transform.localScale = new Vector3(4, 4, 1);
        }
        else {

        }

        if ((Input.GetButtonDown("Jump")) && (collider.IsTouchingLayers(ground)))
        {

            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpForce);
            state = State.jumping;

        }

        velocity_state();
        anime.SetInteger("state", (int)state);

    }
    private void velocity_state() {
        if (state == State.jumping)
        {

            if (rigidbody.velocity.y < 0.1f)
            {
                state = State.falling;
            }
        }
        else if (state == State.falling)
        {
            if (collider.IsTouchingLayers(ground))
            {
                state = State.idle;
            }
        }
        else if (Mathf.Abs(rigidbody.velocity.x) > 2f)
        {
            //Moving
            state = State.running;
        }
        else {

            state = State.idle;
        }

    }
}
