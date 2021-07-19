using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingMotion : MonoBehaviour
{

    private Rigidbody2D rb;
    public Rigidbody2D bird;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bird.velocity = new Vector2(-10, rb.velocity.y);
        rb.velocity = new Vector2(-10, rb.velocity.y);

    }
}
