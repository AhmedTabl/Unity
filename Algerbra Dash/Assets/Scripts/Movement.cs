using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 1f;
    public float jumpForce = 1f;
    public GameObject player;
    private bool isOnGround = true;

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        void OnCollisionEnter(Collision collision)
        {
            isOnGround = true;
        }


        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
          
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isOnGround = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);

        }


    }
}
