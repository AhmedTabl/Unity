using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private bool Down;
    [SerializeField] private bool Up;
    [SerializeField] private bool left;
    [SerializeField] private bool right;
    [SerializeField] private float speed = 0;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (Down == true)
        {
            Up = false;
            rb.velocity = new Vector2(0, -speed);
        }
        else if (Up == true)
        {
            Down = false;
            rb.velocity = new Vector2(0, speed);
        }


        if (left == true)
        {
            right = false;
            rb.velocity = new Vector2(-speed, 0);
        }
        else if (right == true)
        {
            left = false;
            rb.velocity = new Vector2(speed, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Vertical Obstacles Movement
        if((transform.position.y >= 42) && (Up == true || Down == true))
        {
            rb.velocity = new Vector2(0, -speed);

        }
       else if ((transform.position.y <= 2) && (Up == true || Down == true))
        {
            rb.velocity = new Vector2(0, speed);
        }

        //Horizontal Obstacles Movement
        if ((transform.position.x >= 170) && (left == true || right == true))
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        else if ((transform.position.x <= 120) && (left == true || right == true))
        {
            rb.velocity = new Vector2(speed, 0);
        }

    }
}
