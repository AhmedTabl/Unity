using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private float speed = 0;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 35)
        {
            rb.velocity = new Vector2(0, -speed);

        }else if (transform.position.y <= 2)
        {
            rb.velocity = new Vector2(0, speed);
        }


    }
}
