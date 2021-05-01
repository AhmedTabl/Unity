using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float responseDelay;
    [SerializeField] private float rangeOfVision;
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    private void movement()
    {
        if (((player.position.x -responseDelay < transform.position.x) && (player.position.y < transform.position.y)) && (transform.position.x - player.transform.position.x < rangeOfVision))
        {
            rb.velocity = new Vector2(-speed, -speed);
        }
        else if (((player.position.x  > transform.position.x) && (player.position.y > transform.position.y)) && (transform.position.x - player.transform.position.x < rangeOfVision))
        {
            transform.localScale = new Vector2(-2,2);
            rb.velocity = new Vector2(speed, speed);
        }
        else if (((player.position.x -responseDelay < transform.position.x) && (player.position.y > transform.position.y)) && (transform.position.x - player.transform.position.x < rangeOfVision))
        {
            rb.velocity = new Vector2(-speed, speed);
        }
        else if (((player.position.x  > transform.position.x) && (player.position.y < transform.position.y)) && (transform.position.x - player.transform.position.x < rangeOfVision))
        {
            transform.localScale = new Vector2(-2, 2);
            rb.velocity = new Vector2(speed, -speed);
        }
        else if (((player.position.x == transform.position.x) && (player.position.y < transform.position.y)) && (transform.position.x - player.transform.position.x < rangeOfVision))
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else if (((player.position.x == transform.position.x) && (player.position.y > transform.position.y)) && (transform.position.x - player.transform.position.x < rangeOfVision))
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (((player.position.x -responseDelay < transform.position.x) && (player.position.y == transform.position.y)) && (transform.position.x - player.transform.position.x < rangeOfVision))
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        else if (((player.position.x > transform.position.x) && (player.position.y == transform.position.y)) && (transform.position.x - player.transform.position.x < rangeOfVision))
        {
            rb.velocity = new Vector2(speed, 0);
        }
    }

}