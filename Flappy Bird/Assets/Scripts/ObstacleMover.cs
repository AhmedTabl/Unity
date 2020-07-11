using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private bool upToDown;
    [SerializeField] private bool downToUp;
    [SerializeField] private float speed = 0;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (upToDown == true)
        {
            downToUp = false;
            rb.velocity = new Vector2(0, -speed);
        }
        if (downToUp == true)
        {
            upToDown = false;
            rb.velocity = new Vector2(0, speed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 39)
        {
            rb.velocity = new Vector2(0, -speed);

        }
        if (transform.position.y <= 3)
        {
            rb.velocity = new Vector2(0, speed);
        }


    }
}
