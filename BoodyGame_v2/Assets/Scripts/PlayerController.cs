using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //References
    private Rigidbody2D rigidbody;
    private Animator anime;
    private Collider2D collider;
    [SerializeField]private Text CherryCounter;

    //Finite state machine
    private enum State { idle, running, jumping , falling, hurt};
    private State state = State.idle;

    //Inspector variables
    [SerializeField] private LayerMask ground;
    [SerializeField] private float speed = 20f;
    [SerializeField] private float jumpForce = 50f;
    private int cherries = 0;
    [SerializeField] private float HitForce = 50f;


    //Main Functions
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        collider = GetComponent<CapsuleCollider2D>();

    }
    private void Update()
    {
        if (state != State.hurt) {

            Movement();
        }
        Animation_State();
        anime.SetInteger("state", (int)state);
    }


    //Collision and Collectables functions
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collectable") {


            Destroy(collision.gameObject);
            cherries++;
            CherryCounter.text = cherries.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (state == State.falling) {
                Destroy(collision.gameObject);
                Jump();
            }
            else
            {
                state = State.hurt;
                if (collision.transform.position.x > transform.position.x)
                {
                    //The enemy is to our right so we get bounced to the left
                    rigidbody.velocity = new Vector2(-HitForce, rigidbody.velocity.y);

                }
                else
                {
                    //The enemy is to our left so we get boumced to the right
                    rigidbody.velocity = new Vector2(HitForce, rigidbody.velocity.y);
                }
            }
        }
    }

    //Movement and State functions
    private void Movement()
    {
        float horizontal_dirction = Input.GetAxis("Horizontal");

        if (horizontal_dirction < 0f)
        {

            rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
            transform.localScale = new Vector3(-4, 4, 1);
            if (horizontal_dirction > -0.25f)
            {
                rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
            }

        }
        else if (horizontal_dirction > 0f)
        {

            rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
            transform.localScale = new Vector3(4, 4, 1);
            if (horizontal_dirction < 0.25f)
            {
                rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
            }
        }

        if ((Input.GetButtonDown("Jump")) && (collider.IsTouchingLayers(ground)))
        {

            Jump();

        }
    }
    private void Jump()
    {
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpForce);
        state = State.jumping;
    }
    private void Animation_State() {
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
        else if (state == State.hurt)
        {

            if (Mathf.Abs(rigidbody.velocity.x) < 0.1f)
            {
                state = State.idle;
            }
        }
        else if (Mathf.Abs(rigidbody.velocity.x) > 2f)
        {
            
                state = State.running;
        }
        else {

            state = State.idle;
        }
    }
}
