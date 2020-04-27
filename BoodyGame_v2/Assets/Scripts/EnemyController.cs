using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    //Refrence Variables
    [SerializeField] private LayerMask ground;
    [SerializeField]private Transform player;
    private Rigidbody2D rigidbody;
    private CapsuleCollider2D collider;

    //Inspector Variables
    [SerializeField] private float speed;


    //Main Functions
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<CapsuleCollider2D>();
    }
    void Update()
    {
        Movement();
    }

    //Movement and State Functions
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
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
