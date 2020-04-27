using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Rigidbody2D rigidbody;

    [SerializeField] private float speed;
    [SerializeField] private float HitForce = 50f;


    //Main Functions
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Movement();
    }

    //Movement Function
    private void Movement()
    {
        if (player.position.x < transform.position.x)
        {
            //Player is on the left
            rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);

        }
        else if (player.position.x > transform.position.x)
        {
            //Player is on the right
            rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
        }
    }

    //Collision Function
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Player") && (collision.gameObject.transform.position.y <= transform.position.y))
        {
            if (transform.position.x > collision.transform.position.x)
            {
                //The enemy is to our right so we get bounced to the left
                collision.rigidbody.velocity = new Vector2(-HitForce, rigidbody.velocity.y);

            }
            else
            {
                //The enemy is to our left so we get boumced to the right
                collision.rigidbody.velocity = new Vector2(HitForce, rigidbody.velocity.y);
            }
        }else if((collision.gameObject.tag == "Player") && (collision.gameObject.transform.position.y > transform.position.y))
        {
            Destroy(this.gameObject);
        }
    }
}
